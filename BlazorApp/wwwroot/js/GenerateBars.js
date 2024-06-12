function GenerateBars() {
    am5.ready(function () {

        var root = am5.Root.new("chartdiv");

        var myTheme = am5.Theme.new(root);

        myTheme.rule("Label").setAll({
            fill: am5.color(0x76b900),
            fontSize: "1.5em"
        });

        root.setThemes([
            am5themes_Animated.new(root),
            myTheme
        ]);


        var chart = root.container.children.push(am5xy.XYChart.new(root, {
            panX: false,
            panY: false,
            wheelX: "none",
            wheelY: "none",
            paddingLeft: 0
        }));

        chart.zoomOutButton.set("forceHidden", true);


        var yRenderer = am5xy.AxisRendererY.new(root, {
            minGridDistance: 30,
            minorGridEnabled: true
        });

        yRenderer.grid.template.set("location", 1);

        var yAxis = chart.yAxes.push(am5xy.CategoryAxis.new(root, {
            maxDeviation: 0,
            categoryField: "network",
            renderer: yRenderer,
            tooltip: am5.Tooltip.new(root, { themeTags: ["axis"] })
        }));

        var xAxis = chart.xAxes.push(am5xy.ValueAxis.new(root, {
            maxDeviation: 0,
            min: 0,
            numberFormatter: am5.NumberFormatter.new(root, {
                "numberFormat": "#,###a"
            }),
            extraMax: 0.1,
            renderer: am5xy.AxisRendererX.new(root, {
                strokeOpacity: 0.1,
                minGridDistance: 80

            })
        }));


        var series = chart.series.push(am5xy.ColumnSeries.new(root, {
            name: "Series 1",
            xAxis: xAxis,
            yAxis: yAxis,
            valueXField: "value",
            categoryYField: "network",
            tooltip: am5.Tooltip.new(root, {
                pointerOrientation: "left",
                labelText: "{valueX}"
            })
        }));


        series.columns.template.setAll({
            cornerRadiusTR: 5,
            cornerRadiusBR: 5,
            strokeOpacity: 0,

        });

        series.columns.template.adapters.add("fill", function (fill, target) {
            return am5.color("#0x76b900");
        });

        series.columns.template.adapters.add("stroke", function (stroke, target) {
            return am5.color("#000000");
        });


        var data = [
            {
                "network": "RTX 4090",
                "value": 24552
            },
            {
                "network": "RTX 3090",
                "value": 16928
            },
            {
                "network": "RTX 4070",
                "value": 16371
            },
            {
                "network": "RTX 3070 ",
                "value": 12716
            }];

        yAxis.data.setAll(data);
        series.data.setAll(data);
        sortCategoryAxis();

        function getSeriesItem(category) {
            for (var i = 0; i < series.dataItems.length; i++) {
                var dataItem = series.dataItems[i];
                if (dataItem.get("categoryY") == category) {
                    return dataItem;
                }
            }
        }

        chart.set("cursor", am5xy.XYCursor.new(root, {
            behavior: "none",
            xAxis: xAxis,
            yAxis: yAxis
        }));


        function sortCategoryAxis() {

            series.dataItems.sort(function (x, y) {
                return x.get("valueX") - y.get("valueX");
            })

            am5.array.each(yAxis.dataItems, function (dataItem) {
                var seriesDataItem = getSeriesItem(dataItem.get("category"));

                if (seriesDataItem) {
                    var index = series.dataItems.indexOf(seriesDataItem);
                    var deltaPosition = (index - dataItem.get("index", 0)) / series.dataItems.length;
                    dataItem.set("index", index);
                    dataItem.set("deltaPosition", -deltaPosition);
                    dataItem.animate({
                        key: "deltaPosition",
                        to: 0,
                        duration: 1000,
                        easing: am5.ease.out(am5.ease.cubic)
                    })
                }
            });

            yAxis.dataItems.sort(function (x, y) {
                return x.get("index") - y.get("index");
            });
        }
    });
}
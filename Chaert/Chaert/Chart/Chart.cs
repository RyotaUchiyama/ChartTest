﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Control
{
    public partial class Chart : System.Windows.Controls.Control
    {
        // UIオブジェクト
        private Grid        baseGrid;                           // スクロールバー・ラベルのベースとなるGrid
        private Viewbox     chartViewbox;
        private Canvas      chartCanvas;
        private Viewbox     backgroundViewbox;
        private Canvas      backgroundCanvas;
        private Viewbox     gridViewbox;
        private Canvas      gridCanvas;
        private ScrollBar   horizontalScrollBar;
        private ScrollBar   verticalScrollBar;

        // UIプロパティ
        private int lineThickness_Horizontal = 1;               // X軸描画の線の太さ
        private int lineThickness_Vertical = 1;                 // Y軸描画の線の太さ
        private int interval_Horizontal = 30;                   // X軸グリッドの間隔
        private int interval_Vertical = 30;                     // Y軸グリッドの間隔
        private bool isBoldLine = false;                        // 一定カウントで太線描画するか
        private int boldLineCount_Horizontal = 1;               // 太線描画する場合のX軸のカウント数
        private int boldLineCount_Vertical = 1;                 // 太線描画する場合のY軸のカウント数
        private int boldLineThickness_Horizontal = 2;           // 太線描画する場合のX軸の線の太さ
        private int boldLineThickness_Vertical = 2;             // 太線描画する場合のY軸の線の太さ
        private double backgroundOpacity = 1;                   // 背景色の透明度
        private double lineOpacity = 1;                         // 罫線の透明度
        private Brush gridBackgroundColor = Brushes.Black;      // 背景色
        private Brush girdLineColor = Brushes.Gray;             // 方眼カラー
        private Brush girdBoldLineColor = Brushes.DarkGray;     // 方眼太線カラー


        static Chart()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Chart)
                , new FrameworkPropertyMetadata(typeof(Chart)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            // イベント削除
            removeInitalizedEvent();

            // オブジェクト再取得
            baseGrid = this.GetTemplateChild("PART_BaseGrid") as Grid;
            backgroundCanvas = this.GetTemplateChild("PART_BackgroundCanvas") as Canvas;
            backgroundViewbox = this.GetTemplateChild("PART_BackgroundViewbox") as Viewbox;
            gridCanvas = this.GetTemplateChild("PART_GridCanvas") as Canvas;
            gridViewbox = this.GetTemplateChild("PART_GridViewbox") as Viewbox;
            chartCanvas = this.GetTemplateChild("PART_ChartCanvas") as Canvas;
            chartViewbox = this.GetTemplateChild("PART_ChartViewbox") as Viewbox;
            horizontalScrollBar = this.GetTemplateChild("PART_HorizontalScrollBar") as ScrollBar;
            verticalScrollBar = this.GetTemplateChild("PART_VerticalScrollBar") as ScrollBar;

            // イベント設定
            addInitalizedEvent();
            this.init();
        }

        private void init()
        {

            this.chartCanvas.Background = null;
            this.ApplyBackground();

            //demo
            this.Demo();

            this.DrawGrid();
            // demo
            this.Chart_Draw();

        }
    }
}

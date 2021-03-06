﻿using TrackConverter.UI.Ext;

namespace TrackConverter.UI.Shell
{
    /// <summary>
    /// Главное окно программы
    /// </summary>
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileWaypointsRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layerProviderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.источникДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmInternetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmInternetCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearRoutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditWaypoints = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemShowElevGraphOnRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemcreateOptimalRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPointsToRoute = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRouteToPoints = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPointFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateDistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransformCoordinateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNavigatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerVertical = new System.Windows.Forms.SplitContainer();
            this.splitContainerHorizontalLeft = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewConverter = new System.Windows.Forms.DataGridView();
            this.contextMenuStripConverter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileContextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveYandexContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWikimapiaContextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRouteMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadElevationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeElevationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.approximateAltitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalizeTrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTripRouteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinToTripRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createOptimalOnBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separateRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWaypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRouteOnMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevgraphWithIntermediatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elevgraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRouteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addComparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewPoints = new System.Windows.Forms.DataGridView();
            this.contextMenuStripPoints = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWithConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPointOnMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showYandexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemovePointtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerHorizontalRight = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelZoom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRuler = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonMapProvider = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripComboBoxSearch = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonClearSearchMarks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLocateDevice = new System.Windows.Forms.ToolStripButton();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddWaypoint = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеМаршрутаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediatePointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFromtoMarkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWhatsThere = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCoordinatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikimapiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMarker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMarkerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripRoute = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeRouteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelInfo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelFromStart = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelCurrentOperation = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelPosition = new System.Windows.Forms.ToolStripLabel();
            this.gmapControlMap = new TrackConverter.UI.Ext.GMapControlExt();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).BeginInit();
            this.splitContainerVertical.Panel1.SuspendLayout();
            this.splitContainerVertical.Panel2.SuspendLayout();
            this.splitContainerVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalLeft)).BeginInit();
            this.splitContainerHorizontalLeft.Panel1.SuspendLayout();
            this.splitContainerHorizontalLeft.Panel2.SuspendLayout();
            this.splitContainerHorizontalLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConverter)).BeginInit();
            this.contextMenuStripConverter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).BeginInit();
            this.contextMenuStripPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalRight)).BeginInit();
            this.splitContainerHorizontalRight.Panel1.SuspendLayout();
            this.splitContainerHorizontalRight.Panel2.SuspendLayout();
            this.splitContainerHorizontalRight.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            this.contextMenuStripMarker.SuspendLayout();
            this.contextMenuStripRoute.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.картаToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1776, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileWaypointsToolStripMenuItem,
            this.saveFileWaypointsRoutesToolStripMenuItem});
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // saveFileWaypointsToolStripMenuItem
            // 
            this.saveFileWaypointsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileWaypointsToolStripMenuItem.Image")));
            this.saveFileWaypointsToolStripMenuItem.Name = "saveFileWaypointsToolStripMenuItem";
            this.saveFileWaypointsToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.saveFileWaypointsToolStripMenuItem.Text = "Путевые точки в файл";
            this.saveFileWaypointsToolStripMenuItem.ToolTipText = "Сохранение точек, видимых на карте в один файл";
            this.saveFileWaypointsToolStripMenuItem.Click += new System.EventHandler(this.saveFileWaypointsToolStripMenuItem_Click);
            // 
            // saveFileWaypointsRoutesToolStripMenuItem
            // 
            this.saveFileWaypointsRoutesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileWaypointsRoutesToolStripMenuItem.Image")));
            this.saveFileWaypointsRoutesToolStripMenuItem.Name = "saveFileWaypointsRoutesToolStripMenuItem";
            this.saveFileWaypointsRoutesToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.saveFileWaypointsRoutesToolStripMenuItem.Text = "Путевые точки и маршруты в файл";
            this.saveFileWaypointsRoutesToolStripMenuItem.ToolTipText = "Сохранение точек и маршрутов, видимых на карте в один файл";
            this.saveFileWaypointsRoutesToolStripMenuItem.Click += new System.EventHandler(this.saveFileWaypointsRoutesToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.openToolStripMenuItem.Text = "Открыть ";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRouteToolStripMenuItem,
            this.createTripToolStripMenuItem});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 26);
            this.toolStripMenuItem1.Text = "Создать";
            // 
            // createRouteToolStripMenuItem
            // 
            this.createRouteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createRouteToolStripMenuItem.Image")));
            this.createRouteToolStripMenuItem.Name = "createRouteToolStripMenuItem";
            this.createRouteToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.createRouteToolStripMenuItem.Text = "Простой маршрут";
            this.createRouteToolStripMenuItem.Click += new System.EventHandler(this.createRouteToolStripMenuItem_Click);
            // 
            // createTripToolStripMenuItem
            // 
            this.createTripToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createTripToolStripMenuItem.Image")));
            this.createTripToolStripMenuItem.Name = "createTripToolStripMenuItem";
            this.createTripToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.createTripToolStripMenuItem.Text = "Путешествие";
            this.createTripToolStripMenuItem.Click += new System.EventHandler(this.createTripToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapProviderToolStripMenuItem,
            this.layerProviderToolStripMenuItem,
            this.источникДанныхToolStripMenuItem,
            this.selectMapToolStripMenuItem,
            this.очисткаToolStripMenuItem,
            this.инструментыToolStripMenuItem1});
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.картаToolStripMenuItem.Text = "Карта";
            // 
            // mapProviderToolStripMenuItem
            // 
            this.mapProviderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mapProviderToolStripMenuItem.Image")));
            this.mapProviderToolStripMenuItem.Name = "mapProviderToolStripMenuItem";
            this.mapProviderToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.mapProviderToolStripMenuItem.Text = "Поставщик карты";
            this.mapProviderToolStripMenuItem.DropDownOpening += new System.EventHandler(this.toolStripDropDownButtonMapProvider_DropDownOpening);
            // 
            // layerProviderToolStripMenuItem
            // 
            this.layerProviderToolStripMenuItem.Name = "layerProviderToolStripMenuItem";
            this.layerProviderToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.layerProviderToolStripMenuItem.Text = "Слои";
            // 
            // источникДанныхToolStripMenuItem
            // 
            this.источникДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmInternetToolStripMenuItem,
            this.tmCacheToolStripMenuItem,
            this.tmInternetCacheToolStripMenuItem});
            this.источникДанныхToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("источникДанныхToolStripMenuItem.Image")));
            this.источникДанныхToolStripMenuItem.Name = "источникДанныхToolStripMenuItem";
            this.источникДанныхToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.источникДанныхToolStripMenuItem.Text = "Источник данных";
            // 
            // tmInternetToolStripMenuItem
            // 
            this.tmInternetToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tmInternetToolStripMenuItem.Image")));
            this.tmInternetToolStripMenuItem.Name = "tmInternetToolStripMenuItem";
            this.tmInternetToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.tmInternetToolStripMenuItem.Text = "Интернет";
            this.tmInternetToolStripMenuItem.Click += new System.EventHandler(this.tmInternetToolStripMenuItem_Click);
            // 
            // tmCacheToolStripMenuItem
            // 
            this.tmCacheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tmCacheToolStripMenuItem.Image")));
            this.tmCacheToolStripMenuItem.Name = "tmCacheToolStripMenuItem";
            this.tmCacheToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.tmCacheToolStripMenuItem.Text = "Кэш";
            this.tmCacheToolStripMenuItem.Click += new System.EventHandler(this.tmCacheToolStripMenuItem_Click);
            // 
            // tmInternetCacheToolStripMenuItem
            // 
            this.tmInternetCacheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tmInternetCacheToolStripMenuItem.Image")));
            this.tmInternetCacheToolStripMenuItem.Name = "tmInternetCacheToolStripMenuItem";
            this.tmInternetCacheToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.tmInternetCacheToolStripMenuItem.Text = "Интернет+Кэш";
            this.tmInternetCacheToolStripMenuItem.Click += new System.EventHandler(this.tmInternetCacheToolStripMenuItem_Click);
            // 
            // selectMapToolStripMenuItem
            // 
            this.selectMapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("selectMapToolStripMenuItem.Image")));
            this.selectMapToolStripMenuItem.Name = "selectMapToolStripMenuItem";
            this.selectMapToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.selectMapToolStripMenuItem.Text = "Сохранить карту";
            this.selectMapToolStripMenuItem.Click += new System.EventHandler(this.selectMapToolStripMenuItem_Click);
            // 
            // очисткаToolStripMenuItem
            // 
            this.очисткаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearRoutesToolStripMenuItem,
            this.clearMarkersToolStripMenuItem,
            this.clearAllToolStripMenuItem});
            this.очисткаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("очисткаToolStripMenuItem.Image")));
            this.очисткаToolStripMenuItem.Name = "очисткаToolStripMenuItem";
            this.очисткаToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.очисткаToolStripMenuItem.Text = "Очистка";
            // 
            // clearRoutesToolStripMenuItem
            // 
            this.clearRoutesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearRoutesToolStripMenuItem.Image")));
            this.clearRoutesToolStripMenuItem.Name = "clearRoutesToolStripMenuItem";
            this.clearRoutesToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.clearRoutesToolStripMenuItem.Text = "Очистить маршруты";
            this.clearRoutesToolStripMenuItem.Click += new System.EventHandler(this.clearRoutesToolStripMenuItem_Click);
            // 
            // clearMarkersToolStripMenuItem
            // 
            this.clearMarkersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearMarkersToolStripMenuItem.Image")));
            this.clearMarkersToolStripMenuItem.Name = "clearMarkersToolStripMenuItem";
            this.clearMarkersToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.clearMarkersToolStripMenuItem.Text = "Очистить маркеры";
            this.clearMarkersToolStripMenuItem.Click += new System.EventHandler(this.clearMarkersToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.clearAllToolStripMenuItem.Text = "Очистить всё";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem1
            // 
            this.инструментыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditWaypoints,
            this.toolStripMenuItemShowElevGraphOnRoute,
            this.toolStripMenuItemcreateOptimalRoute,
            this.toolStripMenuItem2});
            this.инструментыToolStripMenuItem1.Name = "инструментыToolStripMenuItem1";
            this.инструментыToolStripMenuItem1.Size = new System.Drawing.Size(301, 26);
            this.инструментыToolStripMenuItem1.Text = "Дополнительные инструменты";
            // 
            // toolStripMenuItemEditWaypoints
            // 
            this.toolStripMenuItemEditWaypoints.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemEditWaypoints.Image")));
            this.toolStripMenuItemEditWaypoints.Name = "toolStripMenuItemEditWaypoints";
            this.toolStripMenuItemEditWaypoints.Size = new System.Drawing.Size(334, 26);
            this.toolStripMenuItemEditWaypoints.Text = "Открыть путевые точки в редакторе";
            this.toolStripMenuItemEditWaypoints.ToolTipText = "Открыть в редакторе путевых точек";
            this.toolStripMenuItemEditWaypoints.Click += new System.EventHandler(this.toolStripMenuItemEditWaypoints_Click);
            // 
            // toolStripMenuItemShowElevGraphOnRoute
            // 
            this.toolStripMenuItemShowElevGraphOnRoute.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemShowElevGraphOnRoute.Image")));
            this.toolStripMenuItemShowElevGraphOnRoute.Name = "toolStripMenuItemShowElevGraphOnRoute";
            this.toolStripMenuItemShowElevGraphOnRoute.Size = new System.Drawing.Size(334, 26);
            this.toolStripMenuItemShowElevGraphOnRoute.Text = "Построить профиль высот по пути";
            this.toolStripMenuItemShowElevGraphOnRoute.Click += new System.EventHandler(this.toolStripMenuItemShowElevGraphOnRoute_Click);
            this.toolStripMenuItemShowElevGraphOnRoute.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripMenuItemShowElevGraphOnRoute_Paint);
            // 
            // toolStripMenuItemcreateOptimalRoute
            // 
            this.toolStripMenuItemcreateOptimalRoute.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemcreateOptimalRoute.Image")));
            this.toolStripMenuItemcreateOptimalRoute.Name = "toolStripMenuItemcreateOptimalRoute";
            this.toolStripMenuItemcreateOptimalRoute.Size = new System.Drawing.Size(334, 26);
            this.toolStripMenuItemcreateOptimalRoute.Text = "Построить оптимальный маршрут";
            this.toolStripMenuItemcreateOptimalRoute.ToolTipText = "Построить кратчайший маршрут через все путевые точки. При этом в каждую точку мож" +
    "но попасть только один раз";
            this.toolStripMenuItemcreateOptimalRoute.Click += new System.EventHandler(this.toolStripMenuItemcreateOptimalRoute_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemPointsToRoute,
            this.toolStripMenuItemRouteToPoints});
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(334, 26);
            this.toolStripMenuItem2.Text = "Преобразование";
            // 
            // toolStripMenuItemPointsToRoute
            // 
            this.toolStripMenuItemPointsToRoute.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPointsToRoute.Image")));
            this.toolStripMenuItemPointsToRoute.Name = "toolStripMenuItemPointsToRoute";
            this.toolStripMenuItemPointsToRoute.Size = new System.Drawing.Size(203, 26);
            this.toolStripMenuItemPointsToRoute.Text = "Точки в маршрут";
            this.toolStripMenuItemPointsToRoute.ToolTipText = "Преобразовать путевые точки в маршрут";
            this.toolStripMenuItemPointsToRoute.Click += new System.EventHandler(this.toolStripMenuItemPointsToRoute_Click);
            // 
            // toolStripMenuItemRouteToPoints
            // 
            this.toolStripMenuItemRouteToPoints.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemRouteToPoints.Image")));
            this.toolStripMenuItemRouteToPoints.Name = "toolStripMenuItemRouteToPoints";
            this.toolStripMenuItemRouteToPoints.Size = new System.Drawing.Size(203, 26);
            this.toolStripMenuItemRouteToPoints.Text = "Маршрут в точки";
            this.toolStripMenuItemRouteToPoints.ToolTipText = "Преобразовать все точки всех маршрутов в путевые точки";
            this.toolStripMenuItemRouteToPoints.Click += new System.EventHandler(this.toolStripMenuItemRouteToPoints_Click);
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditPointFileToolStripMenuItem,
            this.CalculateDistanceToolStripMenuItem,
            this.TransformCoordinateToolStripMenuItem,
            this.consoleToolStripMenuItem,
            this.toolStripSeparator2,
            this.OptionsToolStripMenuItem});
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.создатьToolStripMenuItem.Text = "Инструменты";
            // 
            // EditPointFileToolStripMenuItem
            // 
            this.EditPointFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("EditPointFileToolStripMenuItem.Image")));
            this.EditPointFileToolStripMenuItem.Name = "EditPointFileToolStripMenuItem";
            this.EditPointFileToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.EditPointFileToolStripMenuItem.Text = "Правка путевых точек";
            this.EditPointFileToolStripMenuItem.ToolTipText = "Открытие маршрута как последовательность точек с возможностью редактирования";
            this.EditPointFileToolStripMenuItem.Click += new System.EventHandler(this.editPointFileToolStripMenuItem_Click);
            // 
            // CalculateDistanceToolStripMenuItem
            // 
            this.CalculateDistanceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("CalculateDistanceToolStripMenuItem.Image")));
            this.CalculateDistanceToolStripMenuItem.Name = "CalculateDistanceToolStripMenuItem";
            this.CalculateDistanceToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.CalculateDistanceToolStripMenuItem.Text = "Измерение расстояний";
            this.CalculateDistanceToolStripMenuItem.ToolTipText = "Измерение расстояний и азимутов между точками";
            this.CalculateDistanceToolStripMenuItem.Click += new System.EventHandler(this.calculateDistanceToolStripMenuItem_Click);
            // 
            // TransformCoordinateToolStripMenuItem
            // 
            this.TransformCoordinateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("TransformCoordinateToolStripMenuItem.Image")));
            this.TransformCoordinateToolStripMenuItem.Name = "TransformCoordinateToolStripMenuItem";
            this.TransformCoordinateToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.TransformCoordinateToolStripMenuItem.Text = "Преобразование координат";
            this.TransformCoordinateToolStripMenuItem.ToolTipText = "Преобразование координат в разные форматы";
            this.TransformCoordinateToolStripMenuItem.Click += new System.EventHandler(this.transformCoordinateToolStripMenuItem_Click);
            // 
            // consoleToolStripMenuItem
            // 
            this.consoleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consoleToolStripMenuItem.Image")));
            this.consoleToolStripMenuItem.Name = "consoleToolStripMenuItem";
            this.consoleToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.consoleToolStripMenuItem.Text = "Консоль";
            this.consoleToolStripMenuItem.Click += new System.EventHandler(this.consoleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(280, 6);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OptionsToolStripMenuItem.Image")));
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(283, 26);
            this.OptionsToolStripMenuItem.Text = "Настройки";
            this.OptionsToolStripMenuItem.ToolTipText = "Настройки программы";
            this.OptionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNavigatorToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.окноToolStripMenuItem.Text = "Окна";
            // 
            // showNavigatorToolStripMenuItem
            // 
            this.showNavigatorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showNavigatorToolStripMenuItem.Image")));
            this.showNavigatorToolStripMenuItem.Name = "showNavigatorToolStripMenuItem";
            this.showNavigatorToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.showNavigatorToolStripMenuItem.Text = "Панель навигации";
            this.showNavigatorToolStripMenuItem.Click += new System.EventHandler(this.showNavigatorToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.ToolTipText = "Помощь в использовании программы";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripMenuItem.Image")));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.helpToolStripMenuItem.Text = "Помощь";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // splitContainerVertical
            // 
            this.splitContainerVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerVertical.Location = new System.Drawing.Point(0, 28);
            this.splitContainerVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerVertical.Name = "splitContainerVertical";
            // 
            // splitContainerVertical.Panel1
            // 
            this.splitContainerVertical.Panel1.Controls.Add(this.splitContainerHorizontalLeft);
            // 
            // splitContainerVertical.Panel2
            // 
            this.splitContainerVertical.Panel2.Controls.Add(this.splitContainerHorizontalRight);
            this.splitContainerVertical.Size = new System.Drawing.Size(1776, 832);
            this.splitContainerVertical.SplitterDistance = 440;
            this.splitContainerVertical.SplitterWidth = 5;
            this.splitContainerVertical.TabIndex = 3;
            // 
            // splitContainerHorizontalLeft
            // 
            this.splitContainerHorizontalLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHorizontalLeft.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizontalLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerHorizontalLeft.Name = "splitContainerHorizontalLeft";
            this.splitContainerHorizontalLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHorizontalLeft.Panel1
            // 
            this.splitContainerHorizontalLeft.Panel1.Controls.Add(this.button1);
            this.splitContainerHorizontalLeft.Panel1.Controls.Add(this.dataGridViewConverter);
            // 
            // splitContainerHorizontalLeft.Panel2
            // 
            this.splitContainerHorizontalLeft.Panel2.Controls.Add(this.dataGridViewPoints);
            this.splitContainerHorizontalLeft.Size = new System.Drawing.Size(440, 832);
            this.splitContainerHorizontalLeft.SplitterDistance = 474;
            this.splitContainerHorizontalLeft.SplitterWidth = 5;
            this.splitContainerHorizontalLeft.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 226);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewConverter
            // 
            this.dataGridViewConverter.AllowDrop = true;
            this.dataGridViewConverter.AllowUserToAddRows = false;
            this.dataGridViewConverter.AllowUserToDeleteRows = false;
            this.dataGridViewConverter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConverter.ContextMenuStrip = this.contextMenuStripConverter;
            this.dataGridViewConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewConverter.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewConverter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewConverter.Name = "dataGridViewConverter";
            this.dataGridViewConverter.ReadOnly = true;
            this.dataGridViewConverter.Size = new System.Drawing.Size(440, 474);
            this.dataGridViewConverter.TabIndex = 0;
            this.dataGridViewConverter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConverter_CellClick);
            this.dataGridViewConverter.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewConverter_CellFormatting);
            this.dataGridViewConverter.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConverter_CellMouseDoubleClick);
            this.dataGridViewConverter.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewConverter_CellMouseDown);
            this.dataGridViewConverter.SelectionChanged += new System.EventHandler(this.dataGridViewConverter_SelectionChanged);
            this.dataGridViewConverter.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewConverter_DragDrop);
            this.dataGridViewConverter.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewConverter_DragEnter);
            this.dataGridViewConverter.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewConverter_Paint);
            this.dataGridViewConverter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewConverter_KeyDown);
            // 
            // contextMenuStripConverter
            // 
            this.contextMenuStripConverter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripConverter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.изменитьToolStripMenuItem,
            this.показатьToolStripMenuItem,
            this.openRouteFolderToolStripMenuItem,
            this.addToJoinToolStripMenuItem,
            this.addComparisonToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripConverter.Name = "contextMenuStripConverter";
            this.contextMenuStripConverter.Size = new System.Drawing.Size(265, 238);
            this.contextMenuStripConverter.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripConverter_Opening);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.informationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("informationToolStripMenuItem.Image")));
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.informationToolStripMenuItem.Tag = "single";
            this.informationToolStripMenuItem.Text = "Подробная информация";
            this.informationToolStripMenuItem.ToolTipText = "Показать окно с подробной информацией о маршруте";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileContextToolStripMenuItem1,
            this.saveYandexContextToolStripMenuItem,
            this.saveWikimapiaContextToolStripMenuItem});
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить как";
            // 
            // saveFileContextToolStripMenuItem1
            // 
            this.saveFileContextToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveFileContextToolStripMenuItem1.Image")));
            this.saveFileContextToolStripMenuItem1.Name = "saveFileContextToolStripMenuItem1";
            this.saveFileContextToolStripMenuItem1.Size = new System.Drawing.Size(217, 26);
            this.saveFileContextToolStripMenuItem1.Tag = "multy";
            this.saveFileContextToolStripMenuItem1.Text = "Файл";
            this.saveFileContextToolStripMenuItem1.ToolTipText = "Сохранить маршрут в файл";
            this.saveFileContextToolStripMenuItem1.Click += new System.EventHandler(this.saveFileContextToolStripMenuItem1_Click);
            // 
            // saveYandexContextToolStripMenuItem
            // 
            this.saveYandexContextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveYandexContextToolStripMenuItem.Image")));
            this.saveYandexContextToolStripMenuItem.Name = "saveYandexContextToolStripMenuItem";
            this.saveYandexContextToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.saveYandexContextToolStripMenuItem.Tag = "single";
            this.saveYandexContextToolStripMenuItem.Text = "Яндекс - ссылка";
            this.saveYandexContextToolStripMenuItem.Click += new System.EventHandler(this.saveYandexContextToolStripMenuItem_Click);
            // 
            // saveWikimapiaContextToolStripMenuItem
            // 
            this.saveWikimapiaContextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveWikimapiaContextToolStripMenuItem.Image")));
            this.saveWikimapiaContextToolStripMenuItem.Name = "saveWikimapiaContextToolStripMenuItem";
            this.saveWikimapiaContextToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.saveWikimapiaContextToolStripMenuItem.Tag = "single";
            this.saveWikimapiaContextToolStripMenuItem.Text = "Wikimapia - ссылка";
            this.saveWikimapiaContextToolStripMenuItem.Click += new System.EventHandler(this.saveWikimapiaContextToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(264, 26);
            this.saveToolStripMenuItem1.Tag = "single";
            this.saveToolStripMenuItem1.Text = "Сохранить";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRouteMapToolStripMenuItem,
            this.editWaypointsToolStripMenuItem,
            this.loadElevationsToolStripMenuItem,
            this.loadAddressesToolStripMenuItem,
            this.removeElevationsToolStripMenuItem,
            this.approximateAltitudesToolStripMenuItem,
            this.normalizeTrackToolStripMenuItem,
            this.toTripRouteFileToolStripMenuItem,
            this.joinToTripRouteToolStripMenuItem,
            this.createOptimalOnBaseToolStripMenuItem,
            this.separateRouteToolStripMenuItem});
            this.изменитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьToolStripMenuItem.Image")));
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // editRouteMapToolStripMenuItem
            // 
            this.editRouteMapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editRouteMapToolStripMenuItem.Image")));
            this.editRouteMapToolStripMenuItem.Name = "editRouteMapToolStripMenuItem";
            this.editRouteMapToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.editRouteMapToolStripMenuItem.Tag = "single";
            this.editRouteMapToolStripMenuItem.Text = "Редактировать на карте";
            this.editRouteMapToolStripMenuItem.ToolTipText = "Изменение маршрута на карте";
            this.editRouteMapToolStripMenuItem.Click += new System.EventHandler(this.editRouteMapToolStripMenuItem_Click);
            // 
            // editWaypointsToolStripMenuItem
            // 
            this.editWaypointsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editWaypointsToolStripMenuItem.Image")));
            this.editWaypointsToolStripMenuItem.Name = "editWaypointsToolStripMenuItem";
            this.editWaypointsToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.editWaypointsToolStripMenuItem.Tag = "single";
            this.editWaypointsToolStripMenuItem.Text = "Править путевые точки";
            this.editWaypointsToolStripMenuItem.ToolTipText = "Открыть как последовательность точек";
            this.editWaypointsToolStripMenuItem.Click += new System.EventHandler(this.editWaypointsToolStripMenuItem_Click);
            // 
            // loadElevationsToolStripMenuItem
            // 
            this.loadElevationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("loadElevationsToolStripMenuItem.Image")));
            this.loadElevationsToolStripMenuItem.Name = "loadElevationsToolStripMenuItem";
            this.loadElevationsToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.loadElevationsToolStripMenuItem.Tag = "multy";
            this.loadElevationsToolStripMenuItem.Text = "Загрузить высоты точек";
            this.loadElevationsToolStripMenuItem.ToolTipText = "Записать в маршрут высоты всех его точек. Если это путешествие, то будут записаны" +
    " высоты путевых точек и маршрутов";
            this.loadElevationsToolStripMenuItem.Click += new System.EventHandler(this.loadElevationsToolStripMenuItem_Click);
            // 
            // loadAddressesToolStripMenuItem
            // 
            this.loadAddressesToolStripMenuItem.Name = "loadAddressesToolStripMenuItem";
            this.loadAddressesToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.loadAddressesToolStripMenuItem.Text = "Загрузить адреса";
            this.loadAddressesToolStripMenuItem.ToolTipText = "Записать в описания точек адреса этих точек";
            this.loadAddressesToolStripMenuItem.Click += new System.EventHandler(this.loadAddressesToolStripMenuItem_Click);
            // 
            // removeElevationsToolStripMenuItem
            // 
            this.removeElevationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeElevationsToolStripMenuItem.Image")));
            this.removeElevationsToolStripMenuItem.Name = "removeElevationsToolStripMenuItem";
            this.removeElevationsToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.removeElevationsToolStripMenuItem.Tag = "multy";
            this.removeElevationsToolStripMenuItem.Text = "Удалить высоты точек";
            this.removeElevationsToolStripMenuItem.ToolTipText = "Удалить все высоты точек из маршурта";
            this.removeElevationsToolStripMenuItem.Click += new System.EventHandler(this.removeElevationsToolStripMenuItem_Click);
            // 
            // approximateAltitudesToolStripMenuItem
            // 
            this.approximateAltitudesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("approximateAltitudesToolStripMenuItem.Image")));
            this.approximateAltitudesToolStripMenuItem.Name = "approximateAltitudesToolStripMenuItem";
            this.approximateAltitudesToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.approximateAltitudesToolStripMenuItem.Tag = "multy";
            this.approximateAltitudesToolStripMenuItem.Text = "Аппроксимировать высоты";
            this.approximateAltitudesToolStripMenuItem.ToolTipText = "Аппроксимация высот полиномом заданной степени. Степень задаётся в настройках";
            this.approximateAltitudesToolStripMenuItem.Click += new System.EventHandler(this.approximateAltitudesToolStripMenuItem_Click);
            // 
            // normalizeTrackToolStripMenuItem
            // 
            this.normalizeTrackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("normalizeTrackToolStripMenuItem.Image")));
            this.normalizeTrackToolStripMenuItem.Name = "normalizeTrackToolStripMenuItem";
            this.normalizeTrackToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.normalizeTrackToolStripMenuItem.Tag = "multy";
            this.normalizeTrackToolStripMenuItem.Text = "Нормализовать трек";
            this.normalizeTrackToolStripMenuItem.ToolTipText = "Удаление из трека погрешностей, создаваемых GPS";
            this.normalizeTrackToolStripMenuItem.Click += new System.EventHandler(this.normalizeTrackToolStripMenuItem_Click);
            // 
            // toTripRouteFileToolStripMenuItem
            // 
            this.toTripRouteFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toTripRouteFileToolStripMenuItem.Image")));
            this.toTripRouteFileToolStripMenuItem.Name = "toTripRouteFileToolStripMenuItem";
            this.toTripRouteFileToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.toTripRouteFileToolStripMenuItem.Tag = "multy";
            this.toTripRouteFileToolStripMenuItem.Text = "Преобразовать в путешествия";
            this.toTripRouteFileToolStripMenuItem.ToolTipText = "Преобразование каждого выделенного маршрута в отдельное путешествие";
            this.toTripRouteFileToolStripMenuItem.Click += new System.EventHandler(this.toTripRouteFileToolStripMenuItem_Click);
            // 
            // joinToTripRouteToolStripMenuItem
            // 
            this.joinToTripRouteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("joinToTripRouteToolStripMenuItem.Image")));
            this.joinToTripRouteToolStripMenuItem.Name = "joinToTripRouteToolStripMenuItem";
            this.joinToTripRouteToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.joinToTripRouteToolStripMenuItem.Tag = "multy";
            this.joinToTripRouteToolStripMenuItem.Text = "Объединить в путешествие";
            this.joinToTripRouteToolStripMenuItem.ToolTipText = "Объединить выбранные маршруты в одно путешествие";
            this.joinToTripRouteToolStripMenuItem.Click += new System.EventHandler(this.joinToTripRouteToolStripMenuItem_Click);
            // 
            // createOptimalOnBaseToolStripMenuItem
            // 
            this.createOptimalOnBaseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createOptimalOnBaseToolStripMenuItem.Image")));
            this.createOptimalOnBaseToolStripMenuItem.Name = "createOptimalOnBaseToolStripMenuItem";
            this.createOptimalOnBaseToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.createOptimalOnBaseToolStripMenuItem.Text = "Построить оптимальный маршрут";
            this.createOptimalOnBaseToolStripMenuItem.ToolTipText = "Через точки выделенного маршрута построить оптимальный";
            this.createOptimalOnBaseToolStripMenuItem.Click += new System.EventHandler(this.createOptimalOnBaseToolStripMenuItem_Click);
            // 
            // separateRouteToolStripMenuItem
            // 
            this.separateRouteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("separateRouteToolStripMenuItem.Image")));
            this.separateRouteToolStripMenuItem.Name = "separateRouteToolStripMenuItem";
            this.separateRouteToolStripMenuItem.Size = new System.Drawing.Size(325, 26);
            this.separateRouteToolStripMenuItem.Text = "Разделить маршрут";
            this.separateRouteToolStripMenuItem.Click += new System.EventHandler(this.separateRouteToolStripMenuItem_Click);
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showWaypointsToolStripMenuItem,
            this.showRouteOnMapToolStripMenuItem,
            this.elevgraphWithIntermediatesToolStripMenuItem,
            this.elevgraphToolStripMenuItem});
            this.показатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("показатьToolStripMenuItem.Image")));
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.показатьToolStripMenuItem.Text = "Показать";
            // 
            // showWaypointsToolStripMenuItem
            // 
            this.showWaypointsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showWaypointsToolStripMenuItem.Image")));
            this.showWaypointsToolStripMenuItem.Name = "showWaypointsToolStripMenuItem";
            this.showWaypointsToolStripMenuItem.Size = new System.Drawing.Size(397, 26);
            this.showWaypointsToolStripMenuItem.Tag = "multy";
            this.showWaypointsToolStripMenuItem.Text = "Показать точки на карте";
            this.showWaypointsToolStripMenuItem.ToolTipText = "По";
            this.showWaypointsToolStripMenuItem.Click += new System.EventHandler(this.showWaypointsToolStripMenuItem_Click);
            // 
            // showRouteOnMapToolStripMenuItem
            // 
            this.showRouteOnMapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showRouteOnMapToolStripMenuItem.Image")));
            this.showRouteOnMapToolStripMenuItem.Name = "showRouteOnMapToolStripMenuItem";
            this.showRouteOnMapToolStripMenuItem.Size = new System.Drawing.Size(397, 26);
            this.showRouteOnMapToolStripMenuItem.Tag = "multy";
            this.showRouteOnMapToolStripMenuItem.Text = "Маршрут";
            this.showRouteOnMapToolStripMenuItem.Click += new System.EventHandler(this.showOnMapToolStripMenuItem_Click);
            // 
            // elevgraphWithIntermediatesToolStripMenuItem
            // 
            this.elevgraphWithIntermediatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("elevgraphWithIntermediatesToolStripMenuItem.Image")));
            this.elevgraphWithIntermediatesToolStripMenuItem.Name = "elevgraphWithIntermediatesToolStripMenuItem";
            this.elevgraphWithIntermediatesToolStripMenuItem.Size = new System.Drawing.Size(397, 26);
            this.elevgraphWithIntermediatesToolStripMenuItem.Tag = "multy";
            this.elevgraphWithIntermediatesToolStripMenuItem.Text = "Профиль высот с промежуточными точками";
            this.elevgraphWithIntermediatesToolStripMenuItem.ToolTipText = "Показать профиль высот ждя этого трека. Перед построением профиля в трек будут до" +
    "бавлены промежуточные точки для более точного построения";
            this.elevgraphWithIntermediatesToolStripMenuItem.Click += new System.EventHandler(this.elevgraphWithIntermediatesToolStripMenuItem_Click);
            // 
            // elevgraphToolStripMenuItem
            // 
            this.elevgraphToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("elevgraphToolStripMenuItem.Image")));
            this.elevgraphToolStripMenuItem.Name = "elevgraphToolStripMenuItem";
            this.elevgraphToolStripMenuItem.Size = new System.Drawing.Size(397, 26);
            this.elevgraphToolStripMenuItem.Tag = "multy";
            this.elevgraphToolStripMenuItem.Text = "Профиль высот";
            this.elevgraphToolStripMenuItem.Click += new System.EventHandler(this.elevgraphToolStripMenuItem_Click);
            // 
            // openRouteFolderToolStripMenuItem
            // 
            this.openRouteFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openRouteFolderToolStripMenuItem.Image")));
            this.openRouteFolderToolStripMenuItem.Name = "openRouteFolderToolStripMenuItem";
            this.openRouteFolderToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.openRouteFolderToolStripMenuItem.Tag = "single";
            this.openRouteFolderToolStripMenuItem.Text = "Открыть в проводнике";
            this.openRouteFolderToolStripMenuItem.Click += new System.EventHandler(this.openRouteFolderToolStripMenuItem_Click);
            // 
            // addToJoinToolStripMenuItem
            // 
            this.addToJoinToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToJoinToolStripMenuItem.Image")));
            this.addToJoinToolStripMenuItem.Name = "addToJoinToolStripMenuItem";
            this.addToJoinToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.addToJoinToolStripMenuItem.Tag = "multy";
            this.addToJoinToolStripMenuItem.Text = "Добавить в объединение";
            this.addToJoinToolStripMenuItem.ToolTipText = "Добавить маршрут для объединения с другими маршрутами";
            this.addToJoinToolStripMenuItem.Click += new System.EventHandler(this.addToJoinToolStripMenuItem_Click);
            // 
            // addComparisonToolStripMenuItem
            // 
            this.addComparisonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addComparisonToolStripMenuItem.Image")));
            this.addComparisonToolStripMenuItem.Name = "addComparisonToolStripMenuItem";
            this.addComparisonToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.addComparisonToolStripMenuItem.Tag = "multy";
            this.addComparisonToolStripMenuItem.Text = "Добавить в сравнение";
            this.addComparisonToolStripMenuItem.Click += new System.EventHandler(this.addComparisonToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripMenuItem.Image")));
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.removeToolStripMenuItem.Tag = "multy";
            this.removeToolStripMenuItem.Text = "Удалить";
            this.removeToolStripMenuItem.ToolTipText = "Удаление маршрута из списка загруженных";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // dataGridViewPoints
            // 
            this.dataGridViewPoints.AllowUserToAddRows = false;
            this.dataGridViewPoints.AllowUserToDeleteRows = false;
            this.dataGridViewPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPoints.ContextMenuStrip = this.contextMenuStripPoints;
            this.dataGridViewPoints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPoints.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewPoints.Name = "dataGridViewPoints";
            this.dataGridViewPoints.ReadOnly = true;
            this.dataGridViewPoints.Size = new System.Drawing.Size(440, 353);
            this.dataGridViewPoints.TabIndex = 1;
            this.dataGridViewPoints.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoints_CellClick);
            this.dataGridViewPoints.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoints_CellDoubleClick);
            this.dataGridViewPoints.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPoints_CellMouseDown);
            this.dataGridViewPoints.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewPoints_CellValidating);
            this.dataGridViewPoints.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPoints_CellValueChanged);
            this.dataGridViewPoints.SelectionChanged += new System.EventHandler(this.dataGridViewPoints_SelectionChanged);
            this.dataGridViewPoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPoints_KeyDown);
            // 
            // contextMenuStripPoints
            // 
            this.contextMenuStripPoints.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripPoints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPointToolStripMenuItem,
            this.editPointToolStripMenuItem,
            this.openWithConverterToolStripMenuItem,
            this.showPointOnMapToolStripMenuItem,
            this.showYandexToolStripMenuItem,
            this.showGoogleToolStripMenuItem,
            this.RemovePointtoolStripMenuItem});
            this.contextMenuStripPoints.Name = "contextMenuStripPoints";
            this.contextMenuStripPoints.Size = new System.Drawing.Size(316, 186);
            // 
            // addPointToolStripMenuItem
            // 
            this.addPointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addPointToolStripMenuItem.Image")));
            this.addPointToolStripMenuItem.Name = "addPointToolStripMenuItem";
            this.addPointToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.addPointToolStripMenuItem.Text = "Добавить";
            this.addPointToolStripMenuItem.Click += new System.EventHandler(this.addPointToolStripMenuItem_Click);
            // 
            // editPointToolStripMenuItem
            // 
            this.editPointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editPointToolStripMenuItem.Image")));
            this.editPointToolStripMenuItem.Name = "editPointToolStripMenuItem";
            this.editPointToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.editPointToolStripMenuItem.Text = "Изменить";
            this.editPointToolStripMenuItem.Click += new System.EventHandler(this.editPointToolStripMenuItem_Click);
            // 
            // openWithConverterToolStripMenuItem
            // 
            this.openWithConverterToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openWithConverterToolStripMenuItem.Image")));
            this.openWithConverterToolStripMenuItem.Name = "openWithConverterToolStripMenuItem";
            this.openWithConverterToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.openWithConverterToolStripMenuItem.Text = "Открыть в конвертере координат";
            this.openWithConverterToolStripMenuItem.Click += new System.EventHandler(this.openWithConverterToolStripMenuItem_Click);
            // 
            // showPointOnMapToolStripMenuItem
            // 
            this.showPointOnMapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPointOnMapToolStripMenuItem.Image")));
            this.showPointOnMapToolStripMenuItem.Name = "showPointOnMapToolStripMenuItem";
            this.showPointOnMapToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.showPointOnMapToolStripMenuItem.Text = "Покзать на карте";
            this.showPointOnMapToolStripMenuItem.Click += new System.EventHandler(this.showPointOnMapToolStripMenuItem_Click);
            // 
            // showYandexToolStripMenuItem
            // 
            this.showYandexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showYandexToolStripMenuItem.Image")));
            this.showYandexToolStripMenuItem.Name = "showYandexToolStripMenuItem";
            this.showYandexToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.showYandexToolStripMenuItem.Text = "Показать на карте Яндекс";
            this.showYandexToolStripMenuItem.Click += new System.EventHandler(this.showYandexToolStripMenuItem_Click);
            // 
            // showGoogleToolStripMenuItem
            // 
            this.showGoogleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showGoogleToolStripMenuItem.Image")));
            this.showGoogleToolStripMenuItem.Name = "showGoogleToolStripMenuItem";
            this.showGoogleToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.showGoogleToolStripMenuItem.Text = "Показать на карте Google";
            this.showGoogleToolStripMenuItem.Click += new System.EventHandler(this.showGoogleToolStripMenuItem_Click);
            // 
            // RemovePointtoolStripMenuItem
            // 
            this.RemovePointtoolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("RemovePointtoolStripMenuItem.Image")));
            this.RemovePointtoolStripMenuItem.Name = "RemovePointtoolStripMenuItem";
            this.RemovePointtoolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.RemovePointtoolStripMenuItem.Text = "Удалить";
            this.RemovePointtoolStripMenuItem.Click += new System.EventHandler(this.removePointtoolStripMenuItem_Click);
            // 
            // splitContainerHorizontalRight
            // 
            this.splitContainerHorizontalRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerHorizontalRight.Location = new System.Drawing.Point(0, 0);
            this.splitContainerHorizontalRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainerHorizontalRight.Name = "splitContainerHorizontalRight";
            this.splitContainerHorizontalRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerHorizontalRight.Panel1
            // 
            this.splitContainerHorizontalRight.Panel1.Controls.Add(this.gmapControlMap);
            this.splitContainerHorizontalRight.Panel1.Controls.Add(this.toolStrip2);
            this.splitContainerHorizontalRight.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainerHorizontalRight.Panel2
            // 
            this.splitContainerHorizontalRight.Panel2.Controls.Add(this.zedGraph);
            this.splitContainerHorizontalRight.Size = new System.Drawing.Size(1331, 832);
            this.splitContainerHorizontalRight.SplitterDistance = 475;
            this.splitContainerHorizontalRight.SplitterWidth = 5;
            this.splitContainerHorizontalRight.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonZoomIn,
            this.toolStripButtonZoomOut,
            this.toolStripLabelZoom,
            this.toolStripSeparator3,
            this.toolStripButtonRuler});
            this.toolStrip2.Location = new System.Drawing.Point(0, 28);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(25, 447);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButtonZoomIn
            // 
            this.toolStripButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomIn.Image")));
            this.toolStripButtonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomIn.Margin = new System.Windows.Forms.Padding(0, 30, 0, 2);
            this.toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            this.toolStripButtonZoomIn.Size = new System.Drawing.Size(22, 24);
            this.toolStripButtonZoomIn.ToolTipText = "Приблизить";
            this.toolStripButtonZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            // 
            // toolStripButtonZoomOut
            // 
            this.toolStripButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonZoomOut.Image")));
            this.toolStripButtonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomOut.Name = "toolStripButtonZoomOut";
            this.toolStripButtonZoomOut.Size = new System.Drawing.Size(22, 24);
            this.toolStripButtonZoomOut.ToolTipText = "Отдалить";
            this.toolStripButtonZoomOut.Click += new System.EventHandler(this.toolStripButtonZoomOut_Click);
            // 
            // toolStripLabelZoom
            // 
            this.toolStripLabelZoom.Name = "toolStripLabelZoom";
            this.toolStripLabelZoom.Size = new System.Drawing.Size(22, 0);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(22, 6);
            // 
            // toolStripButtonRuler
            // 
            this.toolStripButtonRuler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRuler.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRuler.Image")));
            this.toolStripButtonRuler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRuler.Name = "toolStripButtonRuler";
            this.toolStripButtonRuler.Size = new System.Drawing.Size(22, 24);
            this.toolStripButtonRuler.ToolTipText = "Измерение расстояний";
            this.toolStripButtonRuler.Click += new System.EventHandler(this.toolStripButtonRuler_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUndo,
            this.toolStripDropDownButtonMapProvider,
            this.toolStripComboBoxSearch,
            this.toolStripButtonFind,
            this.toolStripButtonClearSearchMarks,
            this.toolStripButtonLocateDevice});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1331, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Enabled = false;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonUndo.Text = "toolStripButton1";
            this.toolStripButtonUndo.ToolTipText = "Отменить последнее действие";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripDropDownButtonMapProvider
            // 
            this.toolStripDropDownButtonMapProvider.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonMapProvider.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonMapProvider.Image")));
            this.toolStripDropDownButtonMapProvider.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonMapProvider.Name = "toolStripDropDownButtonMapProvider";
            this.toolStripDropDownButtonMapProvider.Size = new System.Drawing.Size(34, 25);
            this.toolStripDropDownButtonMapProvider.Text = "Поставщик карты";
            this.toolStripDropDownButtonMapProvider.ToolTipText = "Выбор источника карты";
            this.toolStripDropDownButtonMapProvider.DropDownOpening += new System.EventHandler(this.toolStripDropDownButtonMapProvider_DropDownOpening);
            // 
            // toolStripComboBoxSearch
            // 
            this.toolStripComboBoxSearch.AutoSize = false;
            this.toolStripComboBoxSearch.AutoToolTip = true;
            this.toolStripComboBoxSearch.CausesValidation = false;
            this.toolStripComboBoxSearch.DropDownWidth = 200;
            this.toolStripComboBoxSearch.MaxDropDownItems = 10;
            this.toolStripComboBoxSearch.Name = "toolStripComboBoxSearch";
            this.toolStripComboBoxSearch.Size = new System.Drawing.Size(332, 28);
            this.toolStripComboBoxSearch.ToolTipText = "Введите адрес";
            this.toolStripComboBoxSearch.DropDown += new System.EventHandler(this.toolStripComboBoxSearch_DropDown);
            this.toolStripComboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxSearch_SelectedIndexChanged);
            this.toolStripComboBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBoxSearch_KeyDown);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonFind.ToolTipText = "Найти";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripButtonClearSearchMarks
            // 
            this.toolStripButtonClearSearchMarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClearSearchMarks.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClearSearchMarks.Image")));
            this.toolStripButtonClearSearchMarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonClearSearchMarks.Name = "toolStripButtonClearSearchMarks";
            this.toolStripButtonClearSearchMarks.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonClearSearchMarks.ToolTipText = "Удалить маркеры найденных объектов";
            this.toolStripButtonClearSearchMarks.Click += new System.EventHandler(this.toolStripButtonClearSearchMarks_Click);
            // 
            // toolStripButtonLocateDevice
            // 
            this.toolStripButtonLocateDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLocateDevice.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLocateDevice.Image")));
            this.toolStripButtonLocateDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLocateDevice.Name = "toolStripButtonLocateDevice";
            this.toolStripButtonLocateDevice.Size = new System.Drawing.Size(24, 25);
            this.toolStripButtonLocateDevice.Text = "toolStripButton1";
            this.toolStripButtonLocateDevice.ToolTipText = "Показать местоположение устройства";
            this.toolStripButtonLocateDevice.Visible = false;
            this.toolStripButtonLocateDevice.Click += new System.EventHandler(this.toolStripButtonLocateDevice_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph.Location = new System.Drawing.Point(0, 0);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(1331, 352);
            this.zedGraph.TabIndex = 0;
            this.zedGraph.UseExtendedPrintDialog = true;
            this.zedGraph.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraph_PointValueEvent);
            this.zedGraph.MouseMoveEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zedGraph_MouseMoveEvent);
            this.zedGraph.MouseLeave += new System.EventHandler(this.zedGraph_MouseLeave);
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddWaypoint,
            this.созданиеМаршрутаToolStripMenuItem,
            this.toolStripMenuItemWhatsThere,
            this.copyCoordinatesToolStripMenuItem,
            this.wikimapiaToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Size = new System.Drawing.Size(256, 134);
            this.contextMenuStripMap.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMap_Opening);
            // 
            // toolStripMenuItemAddWaypoint
            // 
            this.toolStripMenuItemAddWaypoint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItemAddWaypoint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemAddWaypoint.Image")));
            this.toolStripMenuItemAddWaypoint.Name = "toolStripMenuItemAddWaypoint";
            this.toolStripMenuItemAddWaypoint.Size = new System.Drawing.Size(255, 26);
            this.toolStripMenuItemAddWaypoint.Text = "Добавить точку";
            this.toolStripMenuItemAddWaypoint.Click += new System.EventHandler(this.toolStripMenuItemAddWaypoint_Click);
            // 
            // созданиеМаршрутаToolStripMenuItem
            // 
            this.созданиеМаршрутаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromToolStripMenuItem,
            this.intermediatePointToolStripMenuItem,
            this.toToolStripMenuItem,
            this.clearFromtoMarkersToolStripMenuItem});
            this.созданиеМаршрутаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("созданиеМаршрутаToolStripMenuItem.Image")));
            this.созданиеМаршрутаToolStripMenuItem.Name = "созданиеМаршрутаToolStripMenuItem";
            this.созданиеМаршрутаToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.созданиеМаршрутаToolStripMenuItem.Text = "Создание маршрута";
            // 
            // fromToolStripMenuItem
            // 
            this.fromToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromToolStripMenuItem.Image")));
            this.fromToolStripMenuItem.Name = "fromToolStripMenuItem";
            this.fromToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.fromToolStripMenuItem.Tag = "from";
            this.fromToolStripMenuItem.Text = "Отсюда";
            this.fromToolStripMenuItem.Click += new System.EventHandler(this.fromToolStripMenuItem_Click);
            // 
            // intermediatePointToolStripMenuItem
            // 
            this.intermediatePointToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("intermediatePointToolStripMenuItem.Image")));
            this.intermediatePointToolStripMenuItem.Name = "intermediatePointToolStripMenuItem";
            this.intermediatePointToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.intermediatePointToolStripMenuItem.Tag = "intermediate";
            this.intermediatePointToolStripMenuItem.Text = "Промежуточная точка";
            this.intermediatePointToolStripMenuItem.Click += new System.EventHandler(this.intermediatePointToolStripMenuItem_Click);
            // 
            // toToolStripMenuItem
            // 
            this.toToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toToolStripMenuItem.Image")));
            this.toToolStripMenuItem.Name = "toToolStripMenuItem";
            this.toToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.toToolStripMenuItem.Tag = "to";
            this.toToolStripMenuItem.Text = "Сюда";
            this.toToolStripMenuItem.Click += new System.EventHandler(this.toToolStripMenuItem_Click);
            // 
            // clearFromtoMarkersToolStripMenuItem
            // 
            this.clearFromtoMarkersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearFromtoMarkersToolStripMenuItem.Image")));
            this.clearFromtoMarkersToolStripMenuItem.Name = "clearFromtoMarkersToolStripMenuItem";
            this.clearFromtoMarkersToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.clearFromtoMarkersToolStripMenuItem.Text = "Сброс маркеров";
            this.clearFromtoMarkersToolStripMenuItem.Click += new System.EventHandler(this.clearFromtoMarkersToolStripMenuItem_Click);
            // 
            // toolStripMenuItemWhatsThere
            // 
            this.toolStripMenuItemWhatsThere.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemWhatsThere.Image")));
            this.toolStripMenuItemWhatsThere.Name = "toolStripMenuItemWhatsThere";
            this.toolStripMenuItemWhatsThere.Size = new System.Drawing.Size(255, 26);
            this.toolStripMenuItemWhatsThere.Text = "Что здесь?";
            this.toolStripMenuItemWhatsThere.Click += new System.EventHandler(this.toolStripMenuItemWhatsThere_Click);
            // 
            // copyCoordinatesToolStripMenuItem
            // 
            this.copyCoordinatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyCoordinatesToolStripMenuItem.Image")));
            this.copyCoordinatesToolStripMenuItem.Name = "copyCoordinatesToolStripMenuItem";
            this.copyCoordinatesToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.copyCoordinatesToolStripMenuItem.Text = "Копировать координаты";
            this.copyCoordinatesToolStripMenuItem.Click += new System.EventHandler(this.copyCoordinatesToolStripMenuItem_Click);
            // 
            // wikimapiaToolStripMenuItem
            // 
            this.wikimapiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createObjectToolStripMenuItem,
            this.editObjectToolStripMenuItem,
            this.removeObjectToolStripMenuItem});
            this.wikimapiaToolStripMenuItem.Name = "wikimapiaToolStripMenuItem";
            this.wikimapiaToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.wikimapiaToolStripMenuItem.Text = "Wikimapia";
            // 
            // createObjectToolStripMenuItem
            // 
            this.createObjectToolStripMenuItem.Name = "createObjectToolStripMenuItem";
            this.createObjectToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.createObjectToolStripMenuItem.Text = "Создать объект";
            this.createObjectToolStripMenuItem.Click += new System.EventHandler(this.createObjectToolStripMenuItem_Click);
            // 
            // editObjectToolStripMenuItem
            // 
            this.editObjectToolStripMenuItem.Name = "editObjectToolStripMenuItem";
            this.editObjectToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.editObjectToolStripMenuItem.Text = "Редактировать объект";
            this.editObjectToolStripMenuItem.Click += new System.EventHandler(this.editObjectToolStripMenuItem_Click);
            // 
            // removeObjectToolStripMenuItem
            // 
            this.removeObjectToolStripMenuItem.Name = "removeObjectToolStripMenuItem";
            this.removeObjectToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.removeObjectToolStripMenuItem.Text = "Удалить объект";
            this.removeObjectToolStripMenuItem.Click += new System.EventHandler(this.removeObjectToolStripMenuItem_Click);
            // 
            // contextMenuStripMarker
            // 
            this.contextMenuStripMarker.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMarker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMarkerToolStripMenuItem,
            this.deleteMarkerToolStripMenuItem});
            this.contextMenuStripMarker.Name = "contextMenuStripMarker";
            this.contextMenuStripMarker.Size = new System.Drawing.Size(152, 56);
            this.contextMenuStripMarker.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripMarker_Opening);
            // 
            // editMarkerToolStripMenuItem
            // 
            this.editMarkerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editMarkerToolStripMenuItem.Image")));
            this.editMarkerToolStripMenuItem.Name = "editMarkerToolStripMenuItem";
            this.editMarkerToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.editMarkerToolStripMenuItem.Text = "Изменить";
            this.editMarkerToolStripMenuItem.Click += new System.EventHandler(this.editMarkerToolStripMenuItem_Click);
            // 
            // deleteMarkerToolStripMenuItem
            // 
            this.deleteMarkerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteMarkerToolStripMenuItem.Image")));
            this.deleteMarkerToolStripMenuItem.Name = "deleteMarkerToolStripMenuItem";
            this.deleteMarkerToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.deleteMarkerToolStripMenuItem.Text = "Удалить";
            this.deleteMarkerToolStripMenuItem.Click += new System.EventHandler(this.deleteMarkerToolStripMenuItem_Click);
            // 
            // contextMenuStripRoute
            // 
            this.contextMenuStripRoute.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripRoute.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRouteToolStripMenuItem,
            this.removeRouteToolStripMenuItem});
            this.contextMenuStripRoute.Name = "contextMenuStripRoute";
            this.contextMenuStripRoute.Size = new System.Drawing.Size(185, 56);
            // 
            // editRouteToolStripMenuItem
            // 
            this.editRouteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editRouteToolStripMenuItem.Image")));
            this.editRouteToolStripMenuItem.Name = "editRouteToolStripMenuItem";
            this.editRouteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.editRouteToolStripMenuItem.Text = "Редактировать";
            this.editRouteToolStripMenuItem.Click += new System.EventHandler(this.editRouteToolStripMenuItem_Click);
            // 
            // removeRouteToolStripMenuItem
            // 
            this.removeRouteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeRouteToolStripMenuItem.Image")));
            this.removeRouteToolStripMenuItem.Name = "removeRouteToolStripMenuItem";
            this.removeRouteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.removeRouteToolStripMenuItem.Text = "Удалить";
            this.removeRouteToolStripMenuItem.Click += new System.EventHandler(this.removeRouteToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 860);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1776, 25);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelInfo,
            this.toolStripLabelFromStart,
            this.toolStripLabelCurrentOperation});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(1556, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabelInfo
            // 
            this.toolStripLabelInfo.Name = "toolStripLabelInfo";
            this.toolStripLabelInfo.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelInfo.Text = "toolStripLabel1";
            // 
            // toolStripLabelFromStart
            // 
            this.toolStripLabelFromStart.Name = "toolStripLabelFromStart";
            this.toolStripLabelFromStart.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelFromStart.Text = "toolStripLabel1";
            // 
            // toolStripLabelCurrentOperation
            // 
            this.toolStripLabelCurrentOperation.Name = "toolStripLabelCurrentOperation";
            this.toolStripLabelCurrentOperation.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelCurrentOperation.Text = "toolStripLabel1";
            // 
            // toolStrip4
            // 
            this.toolStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelPosition});
            this.toolStrip4.Location = new System.Drawing.Point(1556, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(220, 25);
            this.toolStrip4.TabIndex = 1;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // toolStripLabelPosition
            // 
            this.toolStripLabelPosition.Name = "toolStripLabelPosition";
            this.toolStripLabelPosition.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabelPosition.Text = "toolStripLabel1";
            // 
            // gmapControlMap
            // 
            this.gmapControlMap.Bearing = 0F;
            this.gmapControlMap.CanDragMap = true;
            this.gmapControlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapControlMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapControlMap.GrayScaleMode = false;
            this.gmapControlMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapControlMap.LevelsKeepInMemmory = 5;
            this.gmapControlMap.Location = new System.Drawing.Point(25, 28);
            this.gmapControlMap.Margin = new System.Windows.Forms.Padding(4);
            this.gmapControlMap.MarkersEnabled = true;
            this.gmapControlMap.MaxZoom = 2;
            this.gmapControlMap.MinZoom = 2;
            this.gmapControlMap.MouseWheelZoomEnabled = true;
            this.gmapControlMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapControlMap.Name = "gmapControlMap";
            this.gmapControlMap.NegativeMode = false;
            this.gmapControlMap.PolygonsEnabled = true;
            this.gmapControlMap.RetryLoadTile = 0;
            this.gmapControlMap.RoutesEnabled = true;
            this.gmapControlMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapControlMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapControlMap.ShowTileGridLines = false;
            this.gmapControlMap.Size = new System.Drawing.Size(1306, 447);
            this.gmapControlMap.TabIndex = 0;
            this.gmapControlMap.Zoom = 0D;
            this.gmapControlMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmapControlMap_OnMarkerClick);
            this.gmapControlMap.OnRouteClick += new GMap.NET.WindowsForms.RouteClick(this.gmapControlMap_OnRouteClick);
            this.gmapControlMap.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gmapControlMap_OnMarkerEnter);
            this.gmapControlMap.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gmapControlMap_OnMarkerLeave);
            this.gmapControlMap.OnPositionChanged += new GMap.NET.PositionChanged(this.gmapControlMap_OnPositionChanged);
            this.gmapControlMap.OnMapDrag += new GMap.NET.MapDrag(this.gmapControlMap_OnMapDrag);
            this.gmapControlMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmapControlMap_OnMapZoomChanged);
            this.gmapControlMap.OnMapTypeChanged += new GMap.NET.MapTypeChanged(this.gmapControlMap_OnMapTypeChanged);
            this.gmapControlMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmapControlMap_MouseClick);
            this.gmapControlMap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmapControlMap_MouseDoubleClick);
            this.gmapControlMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gmapControlMap_MouseDown);
            this.gmapControlMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gmapControlMap_MouseMove);
            this.gmapControlMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gmapControlMap_MouseUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 885);
            this.Controls.Add(this.splitContainerVertical);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackConverter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Shown += new System.EventHandler(this.formMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainerVertical.Panel1.ResumeLayout(false);
            this.splitContainerVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerVertical)).EndInit();
            this.splitContainerVertical.ResumeLayout(false);
            this.splitContainerHorizontalLeft.Panel1.ResumeLayout(false);
            this.splitContainerHorizontalLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalLeft)).EndInit();
            this.splitContainerHorizontalLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConverter)).EndInit();
            this.contextMenuStripConverter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPoints)).EndInit();
            this.contextMenuStripPoints.ResumeLayout(false);
            this.splitContainerHorizontalRight.Panel1.ResumeLayout(false);
            this.splitContainerHorizontalRight.Panel1.PerformLayout();
            this.splitContainerHorizontalRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerHorizontalRight)).EndInit();
            this.splitContainerHorizontalRight.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStripMap.ResumeLayout(false);
            this.contextMenuStripMarker.ResumeLayout(false);
            this.contextMenuStripRoute.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

#endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditPointFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculateDistanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransformCoordinateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        /// <summary>
        /// поле ввода поискового запроса на карте
        /// </summary>
        public System.Windows.Forms.ToolStripComboBox toolStripComboBoxSearch;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonRuler;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileWaypointsRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem источникДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearRoutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMarkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditWaypoints;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemcreateOptimalRoute;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPointsToRoute;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRouteToPoints;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNavigatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        /// <summary>
        /// кнопка источника данных Интернет
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem tmInternetToolStripMenuItem;
        /// <summary>
        /// кнопка источника данных Кэш
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem tmCacheToolStripMenuItem;
        /// <summary>
        /// кнопка источника данных Интернет+Кэш
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem tmInternetCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddWaypoint;
        private System.Windows.Forms.ToolStripMenuItem созданиеМаршрутаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediatePointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWhatsThere;
        private System.Windows.Forms.ToolStripMenuItem copyCoordinatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMarkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRouteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeRouteToolStripMenuItem;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStripMarker;
        internal System.Windows.Forms.ContextMenuStrip contextMenuStripRoute;
        internal System.Windows.Forms.ToolStripLabel toolStripLabelZoom;
        internal System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripConverter;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileContextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveYandexContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWikimapiaContextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadElevationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeElevationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem approximateAltitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalizeTrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWaypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRouteOnMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevgraphWithIntermediatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elevgraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addComparisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        internal System.Windows.Forms.DataGridView dataGridViewConverter;
        internal System.Windows.Forms.ToolStripMenuItem toTripRouteFileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem joinToTripRouteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem addToJoinToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem editRouteMapToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem openRouteFolderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowElevGraphOnRoute;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripPoints;
        private System.Windows.Forms.ToolStripMenuItem addPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWithConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPointOnMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showYandexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGoogleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemovePointtoolStripMenuItem;
        internal System.Windows.Forms.DataGridView dataGridViewPoints;
        internal ZedGraph.ZedGraphControl zedGraph;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonMapProvider;
        /// <summary>
        /// кнопка источника карты
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem mapProviderToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem clearFromtoMarkersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem editMarkerToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonClearSearchMarks;
        /// <summary>
        /// вертикальный сплиттер
        /// </summary>
        public System.Windows.Forms.SplitContainer splitContainerVertical;
        /// <summary>
        /// левый горизонтальный сплиттер
        /// </summary>
        public System.Windows.Forms.SplitContainer splitContainerHorizontalLeft;
        /// <summary>
        /// правый горизонтальный сплиттер
        /// </summary>
        public System.Windows.Forms.SplitContainer splitContainerHorizontalRight;
        /// <summary>
        /// кнопка создания оптимального маршрута на основе другого
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem createOptimalOnBaseToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem separateRouteToolStripMenuItem;
        /// <summary>
        /// источник данных слоя карты
        /// </summary>
        public System.Windows.Forms.ToolStripMenuItem layerProviderToolStripMenuItem;
        /// <summary>
        /// область показа карты
        /// </summary>
        public GMapControlExt gmapControlMap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelCurrentOperation;
        private System.Windows.Forms.ToolStrip toolStrip4;
        public System.Windows.Forms.ToolStripLabel toolStripLabelPosition;
        public System.Windows.Forms.ToolStripLabel toolStripLabelFromStart;
        public System.Windows.Forms.ToolStripLabel toolStripLabelInfo;
        private System.Windows.Forms.ToolStripButton toolStripButtonLocateDevice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem loadAddressesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem wikimapiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createObjectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem editObjectToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem removeObjectToolStripMenuItem;
    }
}


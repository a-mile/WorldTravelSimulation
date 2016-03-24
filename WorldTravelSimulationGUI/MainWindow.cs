﻿using System.Drawing;
using System.Windows.Forms;
using WorldTravelSimulation.Classes.Area;
using WorldTravelSimulation.Classes.Generators;

namespace WorldTravelSimulationGUI
{
    public partial class MainWindow : Form
    {
        private readonly Map _map;

        public MainWindow()
        {
            ClientSize = new Size(1280,720);

            _map = new Map(1280, 720);            
            _map.GenerateMap();

            MapDraw();            
            
            InitializeComponent();
        }

        public void MapDraw()
        {
            PictureBox mapPictureBox = new PictureBox
            {
                Image = BitmapGenerator.GenerateFieldMapBitmap(_map),
                Location = new Point(0, 0),
                Size = ClientSize
            };
            Controls.Add(mapPictureBox);
        }        
    }
}

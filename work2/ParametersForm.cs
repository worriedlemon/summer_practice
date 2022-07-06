using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work2
{
    public partial class ParametersForm : Form
    {
        private readonly TrajectoryParameters parameters;
        private readonly Bitmap TrajectoryColorImage;
        private readonly Bitmap FillColorImage;

        public ParametersForm()
        {
            InitializeComponent();
            parameters = TrajectoryParameters.GetInstance();
            TrajectoryColorImage = new(24, 24);
            TrajectoryColorButton.Image = TrajectoryColorImage;
            TrajectoryColorDialog.Color = parameters.trajectoryColor;
            FillColorImage = new(24, 24);
            FillColorButton.Image = FillColorImage;
            FillColorDialog.Color = parameters.triangleFillColor;
        }

        private void ParametersForm_Load(object sender, EventArgs e)
        {
            // Trajectory parameters
            CenterXNumeric.Value = parameters.centerX;
            CenterYNumeric.Value = parameters.centerY;
            RadiusNumeric.Value = parameters.radius;
            SpinCountNumeric.Value = parameters.spinCount;
            StepNumeric.Value = (decimal)parameters.step;
            AngleNumeric.Value = (decimal)(180 / Math.PI * parameters.angle);
            Graphics.FromImage(TrajectoryColorImage).Clear(parameters.trajectoryColor);
            LineThicknessNumeric.Value = (decimal)parameters.lineThickness;
            LineStyleComboBox.SelectedIndex = (int)parameters.lineStyle;

            // Movement parameters
            StartPhaseNumeric.Maximum = EndPhaseNumeric.Value;
            EndPhaseNumeric.Minimum = StartPhaseNumeric.Value;
            StartPhaseNumeric.Value = (decimal)(180 / Math.PI * parameters.startPhase);
            EndPhaseNumeric.Value = (decimal)(180 / Math.PI * parameters.endPhase);
            VelocityNumeric.Value = (decimal)parameters.relativeVelocity;
            SpinMomentumNumeric.Value = (decimal)parameters.spinMomentum;
            DirectionComboBox.SelectedIndex = (1 - (int)(parameters.direction)) / 2;

            // Triangle parameters
            TriangleSideNumeric.Value = parameters.triangleSide;
            Graphics.FromImage(FillColorImage).Clear(parameters.triangleFillColor);
            PulsatingMode.Checked = MinSizeNumeric.Enabled = 
                MaxSizeNumeric.Enabled = PulseSpeedNumeric.Enabled = parameters.pulsating;
            MinSizeNumeric.Value = parameters.minSide;
            MaxSizeNumeric.Value = parameters.maxSide;
            PulseSpeedNumeric.Value = (decimal)parameters.pulsatingSpeed;
            ContourStyleComboBox.SelectedIndex = (int)parameters.contourStyle;
            ContourThicknessNumeric.Value = (int)parameters.contourThickness;
        }

        private void CenterXNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.centerX = (int)CenterXNumeric.Value;
        }

        private void CenterYNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.centerY = (int)CenterYNumeric.Value;
        }

        private void RadiusNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.radius = (int)RadiusNumeric.Value;
        }

        private void SpinCountNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.spinCount = (int)SpinCountNumeric.Value;
        }

        private void StepNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.step = (double)StepNumeric.Value;
        }

        private void AngleNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.angle = (double)AngleNumeric.Value * Math.PI / 180;
        }

        private void TrajectoryColorButton_Click(object sender, EventArgs e)
        {
            if (TrajectoryColorDialog.ShowDialog() != DialogResult.OK) return;
            parameters.trajectoryColor = TrajectoryColorDialog.Color;
            Graphics.FromImage(TrajectoryColorImage).Clear(parameters.trajectoryColor);
        }

        private void DirectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DirectionComboBox.SelectedIndex == 0)
                parameters.direction = TrajectoryParameters.SpinDirection.Clockwise;
            else parameters.direction = TrajectoryParameters.SpinDirection.Counterclockwise;
        }

        private void VelocityNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.relativeVelocity = (double)VelocityNumeric.Value;
        }

        private void StartPhaseNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.startPhase = (double)StartPhaseNumeric.Value * Math.PI / 180;
        }

        private void EndPhaseNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.endPhase = (double)EndPhaseNumeric.Value * Math.PI / 180;
        }

        private void SpinMomentumNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.spinMomentum = (double)SpinMomentumNumeric.Value;
        }

        private void TriangleSideNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.triangleSide = (int)TriangleSideNumeric.Value;
        }

        private void FillColorButton_Click(object sender, EventArgs e)
        {
            if (FillColorDialog.ShowDialog() != DialogResult.OK) return;
            parameters.triangleFillColor = FillColorDialog.Color;
            Graphics.FromImage(FillColorImage).Clear(parameters.triangleFillColor);
        }

        private void PulsatingMode_CheckedChanged(object sender, EventArgs e)
        {
            parameters.pulsating = MinSizeNumeric.Enabled = MaxSizeNumeric.Enabled =
                PulseSpeedNumeric.Enabled = PulsatingMode.Checked;
        }

        private void MinSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.minSide = (int)MinSizeNumeric.Value;
        }

        private void MaxSizeNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.maxSide = (int)MaxSizeNumeric.Value;
        }

        private void PulseSpeedNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.pulsatingSpeed = (double)PulseSpeedNumeric.Value;
        }

        private void LineStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters.lineStyle = (System.Drawing.Drawing2D.DashStyle)LineStyleComboBox.SelectedIndex;
        }

        private void LineThicknessNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.lineThickness = (float)LineThicknessNumeric.Value;
        }

        private void ContourStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parameters.contourStyle = (System.Drawing.Drawing2D.DashStyle)ContourStyleComboBox.SelectedIndex;
        }

        private void ContourThicknessNumeric_ValueChanged(object sender, EventArgs e)
        {
            parameters.contourThickness = (float)ContourThicknessNumeric.Value;
        }
    }
}

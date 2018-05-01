using System;
using System.Windows.Forms;

namespace Expert01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Setting table
            tab.RowCount = 4;
            tab.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            tab.AllowUserToResizeRows = false;

            for (int i = 0; i < 4; ++i)
            {
                tab.Rows[i].Cells[0].Value = (i + 1).ToString();
                tab.Rows[i].Cells[1].Value = "+1";
            }

            tab.Rows[0].Cells[2].Value = "-1";
            tab.Rows[0].Cells[3].Value = "-1";
            tab.Rows[0].Cells[4].Value = "+1";

            tab.Rows[1].Cells[2].Value = "+1";
            tab.Rows[1].Cells[3].Value = "-1";
            tab.Rows[1].Cells[4].Value = "-1";

            tab.Rows[2].Cells[2].Value = "-1";
            tab.Rows[2].Cells[3].Value = "+1";
            tab.Rows[2].Cells[4].Value = "-1";

            tab.Rows[3].Cells[2].Value = "+1";
            tab.Rows[3].Cells[3].Value = "+1";
            tab.Rows[3].Cells[4].Value = "+1";
        }

        private double[] y { get; set; }
        private double AvgIncome { get; set; }
        private double variance { get; set; }
        private double AvgRelease { get; set; }
        private double delta { get; set; }

        private void ExperimentRun()
        {
            y = new double[4];
            int nTask = 200;

            AvgIncome = double.Parse(mEdt.Text);
            variance = double.Parse(varEdt.Text);

            AvgRelease = (double.Parse(aEdt.Text) + double.Parse(bEdt.Text)) / 2.0;
            delta = double.Parse(bEdt.Text) - AvgRelease;
            var Experiment = new Experiment(nTask, AvgIncome, variance, AvgRelease, delta);
                                                   
            y[0] = Experiment.GetResult();
            y[1] = Experiment.GetResult();
            y[2] = Experiment.GetResult();
            y[3] = Experiment.GetResult();
        }

        private void calulateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Calculate coefficients b[]
                double[] b = new double[4];
                b[0] = (y[0] + y[1] + y[2] + y[3]) / 4.0;
                b[1] = (-y[0] + y[1] - y[2] + y[3]) / 4.0;
                b[2] = (-y[0] - y[1] + y[2] + y[3]) / 4.0;
                b[3] = (y[0] - y[1] - y[2] + y[3]) / 4.0;

                b0Edt.Text = b[0].ToString();
                b1Edt.Text = b[1].ToString();
                b2Edt.Text = b[2].ToString();
                b3Edt.Text = b[3].ToString();

                // Calculate y1 & y2
                for (int j = 0; j < 4; ++j)
                {
                    double tmp = b[0] * double.Parse(tab.Rows[j].Cells[1].Value.ToString()) + 
                                 b[1] * double.Parse(tab.Rows[j].Cells[2].Value.ToString()) + 
                                 b[2] * double.Parse(tab.Rows[j].Cells[3].Value.ToString());

                    tab.Rows[j].Cells[6].Value = tmp.ToString();
                    tab.Rows[j].Cells[7].Value = Math.Abs(tmp - y[j]).ToString();

                    tmp += b[3] * double.Parse(tab.Rows[j].Cells[4].Value.ToString());
                    tab.Rows[j].Cells[8].Value = tmp.ToString();
                    double value = (Math.Abs(tmp - y[j]) < 1E-9) ? 0 : Math.Abs(tmp - y[j]);
                    tab.Rows[j].Cells[9].Value = value.ToString();
                }

                // Calculate S1 & S2
                double s1 = 0, s2 = 0;
                for (int j = 0; j < 4; ++j)
                {
                    s1 += Math.Pow(double.Parse(tab.Rows[j].Cells[7].Value.ToString()), 2);
                    s2 += Math.Pow(double.Parse(tab.Rows[j].Cells[9].Value.ToString()), 2);
                }

                s1Edt.Text = s1.ToString("F9");
                s2Edt.Text = s2.ToString("F9");

                // Free memories
                y = null;
                b = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            ExperimentRun();

            for (int j = 0; j < 4; ++j)
            {
                tab[5, j].Value = y[j].ToString();
            }
        }
    }
}

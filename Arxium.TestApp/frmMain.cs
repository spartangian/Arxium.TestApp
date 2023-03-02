using Arxium.TestApp.Models;
using Microsoft.VisualBasic;
using System.Reflection;

namespace Arxium.TestApp
{
    public partial class frmMain : Form
    {
        private Drug _acetaminophen;
        private Drug _oxycotin;
        private Drug _ibuprofen;
        //private IEnumerable<Drug> _drugList;


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadDrugs();
            //_drugList.Select(x => new Label { Text = x.Name, Location = lblDrugName.Location });
            var date = DateTime.UtcNow.ToString("MM/dd/yy HH:mm:ss");
            Logger.Log($"{date} START");
        }

        private void LoadDrugs()
        {
            _acetaminophen = DrugFactory.CreateDrug("Acetaminophen");
            _oxycotin = DrugFactory.CreateDrug("Oxycotin");
            _ibuprofen = DrugFactory.CreateDrug("Ibuprofen");

            this.lblDrug1.Text = _acetaminophen.Name;
            this.lblDrug2.Text = _oxycotin.Name;
            this.lblDrug3.Text = _ibuprofen.Name;

            this.lblCount1.Text = _acetaminophen.GetCount();
            this.lblCount2.Text = _ibuprofen.GetCount();
            this.lblCount3.Text = _oxycotin.GetCount();

            //_drugList = new List<Drug>()
            //{
            //    _acetaminophen,
            //    _oxycotin,
            //    _ibuprofen
            //};
        }

        private void lblIncrementer_Click(object sender, EventArgs e)
        {
            Increment();

        }

        private void Increment()
        {
            Incrementer(_acetaminophen, lblCount1, 1);
            Incrementer(_oxycotin, lblCount2, 1);
            Incrementer(_ibuprofen, lblCount3, 1);
        }

        private void Log(Drug drug)
        {
            var prevCount = drug.GetPreviousCount();
            var newCount = drug.GetCount();
            var logDate = DateTime.UtcNow.ToString("MM/dd/yy HH:mm:ss");

            Logger.Log($"{logDate}-{drug.Name}-{prevCount}-{newCount}");
        }

        private void Incrementer(Drug drug, Label label, int count)
        {
            drug.Increment(count);
            Doer(drug, label);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(_acetaminophen.GetCount() == "0")
            {
                MessageBox.Show("Nothing to reset", "error", MessageBoxButtons.OK);
            }
            else
            {
                Reseter(_acetaminophen, lblCount1);
                Reseter(_oxycotin, lblCount2);
                Reseter(_ibuprofen, lblCount3);
            }
            
        }

        private void Doer(Drug drug, Label label)
        {
            var newCount = drug.GetCount();
            Log(drug);
            Displayer(label, newCount);
        }

        private void Reseter(Drug drug, Label label)
        {
            drug.Reset();
            Doer(drug, label);
        }

        private void Displayer(Label label, string text)
        {
            label.Text = text;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplay a = new frmDisplay();
            a.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
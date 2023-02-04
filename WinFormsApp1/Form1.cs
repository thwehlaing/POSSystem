using POSBase;



namespace WinFormsApp1
{
    public partial class Form1 :BaseForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public override void FunctionProcess(string tagID)
        {
            if (tagID == "2")
            {
                //ErrorCheck(PanelDetail);
                //DBProcess();
            }
            base.FunctionProcess(tagID);
        }
    }
}
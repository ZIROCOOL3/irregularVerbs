using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Speech.Synthesis;
using System.Globalization;
namespace irregularVerbs
{
    public partial class IrregularsVerbs : Telerik.WinControls.UI.RadForm
    {
        public IrregularsVerbs()
        {
            InitializeComponent();
        }
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        PromptBuilder builder = new PromptBuilder();
        private void IrregularsVerbs_Load(object sender, EventArgs e)
        {
            DtgDatos.Rows.Add("be","was","been");
            DtgDatos.Rows.Add("", "were", "");
            DtgDatos.Rows.Add("become", "became", "become");
            DtgDatos.Rows.Add("begin", "began", "begun");




        }

        private void radButton1_Click(object sender, EventArgs e)
        {

        }

        private void DtgDatos_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                synthesizer.SetOutputToDefaultAudioDevice();
                builder.StartVoice(new CultureInfo("en-US"));
                builder.AppendText(e.Value.ToString());
                builder.EndVoice();
                synthesizer.Rate = int.Parse(TrbSpeed.Value.ToString());
                synthesizer.Speak(builder);
                builder.ClearContent();
            }
            catch (Exception)
            {

                
            }

           
        }

        private void DtgDatos_RowFormatting(object sender, RowFormattingEventArgs e)
        {
        
                //e.RowElement.BackColor = System.Drawing.Color.Red;

        }

        private void DtgDatos_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            DtgDatos.Rows[1].Cells[2].Style.BorderBoxStyle = BorderBoxStyle.SingleBorder;
            DtgDatos.Rows[1].Cells[2].Style.BorderBottomWidth = 10;
        }
    }
}


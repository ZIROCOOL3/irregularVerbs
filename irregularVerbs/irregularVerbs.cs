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
            DtgDatos.Rows.Add("Ser/Estar", "be", "was", "been");
            DtgDatos.Rows.Add("", "", "were", "");
            DtgDatos.Rows.Add("volverse", "become", "became", "become");
            DtgDatos.Rows.Add("empezar", "begin", "began", "begun");
            DtgDatos.Rows.Add("rotura", "break", "broke", "broken");
            DtgDatos.Rows.Add("traer", "bring", "brought ", "brought");
            DtgDatos.Rows.Add("construir", "build", "built", "built");
            DtgDatos.Rows.Add("comprar", "buy", "bought", "bought");
            DtgDatos.Rows.Add("Poder", "can", "could", "--");
            DtgDatos.Rows.Add("captura", "catch", "caught ", "caught");
            DtgDatos.Rows.Add("venir", "come", "came", "come");
            DtgDatos.Rows.Add("costo", "cost", "cost", "cost");
            DtgDatos.Rows.Add("hacer", "do", "did ", "done");
            DtgDatos.Rows.Add("beber", "drink", "drank", "drunk");
            DtgDatos.Rows.Add("conducir", "drive", "drove", "driven");
            DtgDatos.Rows.Add("comer", "eat", "ate ", "eaten");
            DtgDatos.Rows.Add("caida", "fall", "fell", "fallen ");
            DtgDatos.Rows.Add("sentir", "feel", "felt", "felt");
            DtgDatos.Rows.Add("encontrar", "find", "found", "found");
            DtgDatos.Rows.Add("volar", "fly", "flew", "flown");
            DtgDatos.Rows.Add("olvidar", "forget", "forgot", "forgotten");
            DtgDatos.Rows.Add("obtener", "get", "got", "got");
            DtgDatos.Rows.Add("dar", "give", "gave", "given");
            DtgDatos.Rows.Add("ir", "go", "went", "gone");
            DtgDatos.Rows.Add("tener", "have", "had", "had");
            DtgDatos.Rows.Add("escuchar", "hear", "heard", "heard");
            DtgDatos.Rows.Add("saber", "know", "knew ", "known");
            DtgDatos.Rows.Add("dejar", "leave", "left", "left");
            DtgDatos.Rows.Add("perder", "lose", "lost", "lost");
            DtgDatos.Rows.Add("hacer", "make", "made", "made");
            DtgDatos.Rows.Add("reunir", "meet", "met", "met");
            DtgDatos.Rows.Add("pagar", "pay", "paid", "paid");
            DtgDatos.Rows.Add("poner", "put ", "put", "put");
            DtgDatos.Rows.Add("leer", "read", "read", "read");
            DtgDatos.Rows.Add("correr", "run", "ran", "run");
            DtgDatos.Rows.Add("decir", "say", "said", "said");
            DtgDatos.Rows.Add("ver", "see", "saw", "seen");
            DtgDatos.Rows.Add("enviar", "send", "sent", "sent");
            DtgDatos.Rows.Add("cantar", "sing ", "sang", "sung");
            DtgDatos.Rows.Add("sentar", "sit", "sat", "sat");
            DtgDatos.Rows.Add("dormir", "sleep", "slept", "slept");
            DtgDatos.Rows.Add("hablar", "speak", "spoke", "spoken");
            DtgDatos.Rows.Add("gastar", "spend", "spent", "spent");
            DtgDatos.Rows.Add("parar", "stand", "stood", "stood");
            DtgDatos.Rows.Add("nadar", "swim ", "swam", "swum");
            DtgDatos.Rows.Add("enseñar", "teach", "taught", "taught");
            DtgDatos.Rows.Add("llevar", "take", "took", "taken");
            DtgDatos.Rows.Add("contar", "tell ", "told", "told");
            DtgDatos.Rows.Add("pensar", "think", "thought", "thought");
            DtgDatos.Rows.Add("comprender", "understand", "understood", "understood");
            DtgDatos.Rows.Add("despertar", "wake", "woke", "woken");
            DtgDatos.Rows.Add("vestir", "wear ", "wore", "worn");
            DtgDatos.Rows.Add("ganar", "win ", "won", "won");
            DtgDatos.Rows.Add("escribir", "write", "wrote", "written");
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
            try
            {
                DtgDatos.Rows[1].Cells[2].Style.BorderBoxStyle = BorderBoxStyle.SingleBorder;
                DtgDatos.Rows[1].Cells[2].Style.BorderBottomWidth = 10;

            }
            catch (Exception)
            {

                
            }
        }
    }
}


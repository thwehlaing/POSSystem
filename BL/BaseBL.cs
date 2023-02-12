using Entity;
using System.Data.SqlClient;
using System.Data;

namespace BL
{
    public class BaseBL
    {
        DBAccessBL bl = new DBAccessBL();
        public static IniEntity IEntity = new IniEntity();
        public string GetConnectionString()
        {

            return "Data Source=" + IEntity.DatabaseServer +
                   ";Initial Catalog=" + IEntity.DatabaseName +
                   ";Persist Security Info=True;User ID=" + IEntity.DatabaseLoginID +
                   ";Password=" + IEntity.DatabasePassword +
                   ";Connection Timeout=" + IEntity.TimeoutValues;
        }

        public DialogResult ShowMessage(string MessageID, string text1 = null, string text2 = null)
        {
            MessageEntity me = new MessageEntity
            {
                MessageID = MessageID,
                MessageText1 = string.IsNullOrWhiteSpace(text1) ? string.Empty : text1,
                MessageText2 = string.IsNullOrWhiteSpace(text2) ? string.Empty : text2
            };

            return GetMessage(me);
        }
        private DialogResult GetMessage(MessageEntity me)
        {
            me.Sqlprms = new SqlParameter[1];
            me.Sqlprms[0] = new SqlParameter("@MessageID", me.MessageID);
            DataTable dtMsg = bl.SelectDatatable("pr_message_select", GetConnectionString(), me.Sqlprms);

            string message = string.Empty;            
            if (dtMsg.Rows.Count > 0)
            {
                message = ReplaceMessage(dtMsg.Rows[0]["MessageText1"].ToString(), me);
                message += !string.IsNullOrWhiteSpace(dtMsg.Rows[0]["MessageText2"].ToString()) ? "\n\n" + ReplaceMessage(dtMsg.Rows[0]["MessageText2"].ToString(), me) : string.Empty;                

                MessageBoxButtons msgbtn = dtMsg.Rows[0]["MessageButton"].ToString().Equals("0") ? MessageBoxButtons.OK :
                                           dtMsg.Rows[0]["MessageButton"].ToString().Equals("2") ? MessageBoxButtons.OKCancel :
                                           //dtMsg.Rows[0]["MessageButton"].ToString().Equals("3") ? MessageBoxButtons.RetryCancel :
                                           dtMsg.Rows[0]["MessageButton"].ToString().Equals("4") ? MessageBoxButtons.YesNo :
                                           dtMsg.Rows[0]["MessageButton"].ToString().Equals("5") ? MessageBoxButtons.YesNoCancel :
                                           MessageBoxButtons.AbortRetryIgnore;

                MessageBoxIcon msgicon = dtMsg.Rows[0]["MessageMark"].ToString().Equals("0") ? MessageBoxIcon.Error:
                                         dtMsg.Rows[0]["MessageMark"].ToString().Equals("1") ? MessageBoxIcon.Information :
                                         //dtMsg.Rows[0]["MessageMark"].ToString().Equals("2") ? MessageBoxIcon.Asterisk :
                                         dtMsg.Rows[0]["MessageMark"].ToString().Equals("3") ? MessageBoxIcon.Question :                                          
                                         //dtMsg.Rows[0]["MessageMark"].ToString().Equals("5") ? MessageBoxIcon.Stop :
                                         dtMsg.Rows[0]["MessageMark"].ToString().Equals("4") ? MessageBoxIcon.Exclamation :
                                         MessageBoxIcon.None;
                if (me.MessageID == "Q003")
                    return MessageBox.Show(message, "", msgbtn, msgicon, MessageBoxDefaultButton.Button2);
                else
                    return MessageBox.Show(message, "", msgbtn, msgicon, MessageBoxDefaultButton.Button1);
            }
            else
            {
                return MessageBox.Show("မက်ဆေ့မရှိပါ", "အမှား(" + me.MessageID + ")", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string ReplaceMessage(string originalText, MessageEntity me)
        {
            if (!string.IsNullOrWhiteSpace(originalText))
            {
                if (originalText.Contains("{0}"))
                    originalText = originalText.Replace("{0}", me.MessageText1);
                if (originalText.Contains("{1}"))
                    originalText = originalText.Replace("{1}", me.MessageText2);
            }
            return originalText;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BB_SiteReloaded.Handlers;

namespace BB_SiteReloaded {
    public partial class Bingo : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            CreateBingoTable();
        }

        private void CreateBingoTable() {

            var s = BingoFileHandler.Get25UniqueStringsAsLists();
            string sc = "";
            for (int i = 0; i < s.Count; i++) {
                sc += CreateBingoTableRow(s[i], i);
            }

            string table = $"<table>" + sc + $"</table>";

            Container.Controls.Add(new Literal() { Text = table });
        }

        private string CreateBingoTableRow(List<string> s, int rowNumber) {
            List<string> cells = new List<string>();
            for (int i = 0; i < s.Count; i++) {
                cells.Add(CreateBingoTableCell(s[i], rowNumber + i));
            }
            string row = $"<tr>{String.Join("", cells)}</tr>";
            return row;
        }

        private string CreateBingoTableCell(string s, int cellIdNumber) {
            return $"<td class='fkup' id='cell{cellIdNumber}'>" +
                $"{s}" +
                $"<input type='hidden' name='field{cellIdNumber}' value=''" +
                $"<input type='hidden' name='yesno' id='yesno{cellIdNumber}' value='no'" +
                $"</td>";
        }
    }
}
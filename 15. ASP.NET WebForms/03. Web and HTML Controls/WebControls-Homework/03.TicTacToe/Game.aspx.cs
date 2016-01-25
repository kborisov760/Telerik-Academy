using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.TicTacToe
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TableRow firstRow = this.MainGameField.Rows[0];
            TableRow secondRow = this.MainGameField.Rows[1];
            TableRow thirdRow = this.MainGameField.Rows[2];

            for (int i = 0; i < 3; i++)
            {
                TableRow currentRow = this.MainGameField.Rows[i];
                for (int j = 0; j < 3; j++)
                {
                    Button cellInvisibleButton = new Button();
                    cellInvisibleButton.Style.Add("width", "100px");
                    cellInvisibleButton.Style.Add("height", "100px");
                    cellInvisibleButton.Style.Add("visability", "hidden");
                    //cellInvisibleButton.ID = (i + j).ToString();
                    //cellInvisibleButton.Attributes.Add("OnClick", "UserCellSelect");
                    cellInvisibleButton.Click += UserCellSelect;

                    TableCell currentCell = currentRow.Cells[j];
                    currentCell.Style.Add("width", "100px");
                    currentCell.Style.Add("height", "100px");
                    currentCell.Style.Add("background-color", "green");
                    //currentCell.ID = (i + j).ToString();
                    currentCell.Controls.Add(cellInvisibleButton);
                }
            }
            
            this.MainGameField.Style.Add("border-radius", "5px");
            this.MainGameField.Style.Add("padding-top", "10%");
            this.MainGameField.Style.Add("padding-left", "35%");
        }

        protected void UserCellSelect(object sender, EventArgs e)
        {
            var currentButton = sender as Button;
            currentButton.Attributes.Add("class", "bgBtnX");
        }
    }
}
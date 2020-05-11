using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebXml
{
    public partial class WebFormXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DataSet d = new DataSet("CONTRYES");
            /*
            DataColumn col1 = new DataColumn("Id",typeof(int),"6",MappingType.Attribute);
           // DataColumn col2 = new DataColumn("Nombre",typeof(string),"China",MappingType.Attribute);
            DataColumn col3 = new DataColumn("Population",typeof(int),"12334444",MappingType.Attribute);

            DataTable table = new DataTable();
            table.Columns.Add(col1);
            // table.Columns.Add(col2);
            table.Columns.Add(col3);
            */
           
            
            /*
            DataSet da = new DataSet("CONTRYES");
          
           //da.ReadXml(Server.MapPath("~/datos/file.xml"));
            DataTable table =new DataTable("Contry");
            table.Columns.Add("Id",typeof(string));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Population", typeof(string));
            DataRow row ;
            row = table.NewRow();
            row["Id"] = "6";
            row["Nombre"] = "peru";
            row["Population"] = "12344";
            table.Rows.Add(row);
            da.Merge(table);
            da.AcceptChanges();
            //da.WriteXml(Server.MapPath("~/datos/file.xml"));
            */
        }

        protected void Grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("~/datos/file.xml"));
            data.Tables[0].Rows[grid1.Rows[e.RowIndex].DataItemIndex].Delete();
             data.WriteXml(Server.MapPath("~/datos/file.xml"));
            
                 /*
            GridViewRow row = grid1.Rows[e.RowIndex];
            String region = row.Cells[1].Text;
           
            // Cancel the delete operation if the country/region is "USA".
            if (region == "USA")
            {
                e.Cancel = true;
                
            }
            */
        }
    }
}
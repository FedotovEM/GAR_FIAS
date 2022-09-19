using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace GAR_FIAS_WorkerService.Repository.Models
{
    [Table("AS_CHANGE_HISTORY")]
    public partial class AsChangeHistory
    {
        [Key]
        [Column("CHANGEID")]
        public long Changeid { get; set; }
        [Column("OBJECTID")]
        public long Objectid { get; set; }
        [Required]
        [Column("ADROBJECTID")]
        [StringLength(36)]
        public string Adrobjectid { get; set; }
        [Column("OPERTYPEID")]
        public int Opertypeid { get; set; }
        [Column("NDOCID")]
        public long? Ndocid { get; set; }
        [Column("CHANGEDATE", TypeName = "date")]
        public DateTime Changedate { get; set; }

        public static AsChangeHistory GetAttributeValue(XmlReader item)
        {
            AsChangeHistory asChangeHistory = new AsChangeHistory();

            item.MoveToAttribute("CHANGEID");
            asChangeHistory.Changeid = long.Parse(item.Value);
            item.MoveToAttribute("OBJECTID");
            asChangeHistory.Objectid = long.Parse(item.Value);
            item.MoveToAttribute("ADROBJECTID");
            asChangeHistory.Adrobjectid = item.Value;
            item.MoveToAttribute("OPERTYPEID");
            asChangeHistory.Opertypeid = int.Parse(item.Value);

            if (item.MoveToAttribute("NDOCID"))
                asChangeHistory.Ndocid = long.Parse(item.Value);
            else
                asChangeHistory.Ndocid = null;

            item.MoveToAttribute("CHANGEDATE");
            asChangeHistory.Changedate = DateTime.Parse(item.Value);

            return asChangeHistory;
        }
    }
}

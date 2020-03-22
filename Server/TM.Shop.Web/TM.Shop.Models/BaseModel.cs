using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TM.Shop.Models
{
    /// <summary>
    /// 所有类的基类
    /// </summary>
    public abstract class BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("id")]
        public long Id { get; set; }

        [StringLength(30, ErrorMessage = "{0}最多输入{1}个字符")]
        [Column("name")]
        public string Name { get; set; }

        [Column("created_date_time")]
        public DateTime CreatedDateTime { get; set; }
    }
}

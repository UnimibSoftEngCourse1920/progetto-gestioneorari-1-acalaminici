using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace TooSharp.Models
{   
    /// <summary>
    ///  TooSharp Generated Code. Do not Modify 
    ///  Date Genereated: 01/03/2020 13:24
    ///  Author: a.calaminici
    /// </summary>
    /// <seealso cref="TooSharp.Core.ITSRelationShips" />
    [DebuggerStepThrough]
    public class TestOne : TooSharp.Core.ITSModel
    {
      #region CODE
	     public static string TableName = "testOne";
         public string GetTableName() { return TableName; }
         public List<string> GetColumns() {return Enum.GetValues(typeof(COLUMNS)).Cast<COLUMNS>().Select(v => v.ToString()).ToList();  }
         public static TooSharp.Core.TSQueryBuilder<TestOne> Records() { return new TooSharp.Core.TSQueryBuilder<TestOne>(TooSharp.TSRelationships.getInstance()); }
         public static TooSharp.Core.TSQueryBuilder<TestOne> Records(object[] columns) { return new TooSharp.Core.TSQueryBuilder<TestOne>(TooSharp.TSRelationships.getInstance(),columns); }
      #endregion
      #region COLUMNS
       public enum COLUMNS
       {
         id,
         LastName,
         FirstName,
         Email,
         Mobile,
         createdAt,
         //column
       }
      #endregion
    }
     [DebuggerStepThrough]
    public class TestOne: TooSharp.Core.TSmodel 
    {
     
       #region PROPERTIES
         [TSKey]
         public int Id { get; private set; }=-1;
         public string LastName { get; set; }
         public string FirstName { get; set; }
         public string Email { get; set; }
         public string Mobile { get; set; }
         public DateTime CreatedAt { get; set; }
         //property
       #endregion
    }
}

namespace AddaptorPattern.Core;

public class Employee
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public IEnumerable<PayItem> PayItems { get; set; } = [];
}



/*
 *  firstname , lastname متقسم ل full name قالك في بيزنس ركويرمنت انه نخلي ال 
 * First,lasts واعمل كونكات لل fullname اسمه field واحد هياجي يقولك بسيطة هعمل  
 */

/*
 * هتعمل بولين فلاج PayItem طيب جه بيزنس مختلف قالك مش هتكتب سالب في ال 
 * هيبقى افضل كاستخدام addaptor هنا دور ال 
 */
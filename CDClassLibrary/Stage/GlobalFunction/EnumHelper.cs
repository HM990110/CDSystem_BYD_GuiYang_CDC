using System.ComponentModel;
using System.Reflection;

namespace CDClassLibrary.Stage
{
    public class EnumHelper
    {
        public static string GetEnumDescription(Enum enumValue)
        {
            try
            {
                string value = enumValue.ToString();
                FieldInfo? field = enumValue.GetType().GetField(value);
                if (field != null)
                {
                    object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);  //获取描述属性
                    if (objs == null || objs.Length == 0)  //当描述属性没有时，直接返回名称
                        return value;
                    DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
                    return descriptionAttribute.Description;
                }
                else
                    return value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("1041:" + ex.Message);
                return "";
            }
        }
    }
}
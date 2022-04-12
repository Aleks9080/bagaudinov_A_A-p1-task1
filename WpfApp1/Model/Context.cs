using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public partial class Product
    {

        public Object getTextDecor
        {
            get
            {
                if (getSale != ProductCost)
                {
                    return TextDecorations.Strikethrough;
                }
                return null;
            }
        }
        public decimal getSale
        {
            get
            {
                if (ProductDiscountAmount != 0)
                {
                    var price = ProductCost.Value * (decimal)(1 - Double.Parse(ProductDiscountAmount.Value.ToString()) / 100);
                    return price;
                }
                return ProductCost.Value;
            }
        }
    }
}

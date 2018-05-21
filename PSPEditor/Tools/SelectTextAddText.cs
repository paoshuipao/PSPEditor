using System;


namespace PSPEditor.EditorUtil
{
    public class SelectTextAddText : SearchText                  //可选择 + Text
    {
        public override void Show(ZuHeTool tool, string searchInput)
        {
            if (!string.IsNullOrEmpty(searchInput) && Text1.ToLower().Contains(searchInput.ToLower()))
            {
                MyCreate.Box_Hei(() =>
                {
                    tool.SelectTextText_B(Text1, Text2);
                });
            }
            else
            {
                tool.SelectTextText(Text1, Text2);

            }
        }

        public SelectTextAddText(string text1, string text2) : base(text1, text2)
        {
        }

    }

    public class SelectTextAddText2 : SearchText                  //可选择 + Text (更多功能)
    {
        public override void Show(ZuHeTool tool, string searchInput)
        {
            if (string.IsNullOrEmpty(searchInput))
            {
                TextShow(tool);
            }
            else
            {
                if (Text1.ToLower().Contains(searchInput.ToLower()))
                {
                    MyCreate.Box_Hei(() =>
                    {
                        TextShow(tool);
                    });
                }
            }


        }

        #region 私有
        private bool IsShow;
        private Action ShowAction;
        private string Des;
        public SelectTextAddText2(string text1, string text2, string des) : base(text1, text2)
        {
            Des = des;
        }

        public SelectTextAddText2(string text1, string text2, string des, Action showAction) : base(text1, text2)
        {
            ShowAction = showAction;
            Des = des;
        }


        private void TextShow(ZuHeTool tool)
        {
            if (null != ShowAction)
            {
                tool.ShowSelectTextDes(Text2, Des, Text1, ref IsShow, ShowAction);
            }
            else
            {
                tool.ShowSelectTextDes(Text2, Des, Text1);
            }
        }

        #endregion


    }



    public class TextAddText : SearchText                        //Text +Text
    {
        public override void Show(ZuHeTool tool, string searchInput)
        {
            if (!string.IsNullOrEmpty(searchInput))
            {
                string input = searchInput.ToLower();
                if (Text1.ToLower().Contains(input) || Text2.Contains(input))
                {
                    MyCreate.Box(() =>
                    {
                        tool.TextText_OY(Text1, Text2);
                    });
                }
            }
            else
            {
                tool.TextText_BL(Text1, Text2);
            }

        }


        public TextAddText(string text1, string text2) : base(text1, text2)
        {
        }
    }




    public abstract class SearchText                             //搜索Text
    {
        public string Text1 { get; protected set; }

        public string Text2 { get; protected set; }

        public abstract void Show(ZuHeTool tool, string searchInput);

        protected SearchText(string text1, string text2)
        {
            Text1 = text1;
            Text2 = text2;
        }
    }

}



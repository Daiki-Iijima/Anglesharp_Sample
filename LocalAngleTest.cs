using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleSample
{
    class LocalAngleTest
    {
        //ローカルで定義したHTMLの変換テスト
        public List<string> CombertHTML()
        {
            var getStList = new List<string>();

            string readedSt = "";

            //ファイルの絶対パスを取得
            var path = Path.GetFullPath("..\\HtmlSample.txt");

            Console.WriteLine(path);

            //テキストを読み込む
            using (var reader = new StreamReader(path))
            {
                readedSt = reader.ReadToEnd();
            }

            // HtmlParserクラスをインスタンス化
            var parser = new HtmlParser();

            // HtmlParserクラスのParserメソッドを使用してパースする。
            // Parserメソッドの戻り値の型はIHtmlDocument
            var htmlDocument = parser.ParseDocument(readedSt);

            // testタグの要素を全て取得する。
            var urlElements = htmlDocument.QuerySelectorAll("test");

            foreach (var data in urlElements)
            {
                //テキスト部分を取得
                getStList.Add(data.TextContent);
            }

            return getStList;
        }

    }
}

//string sentence = "the quick brown fox jumps over the lazy dog";

//string[] sozlar = sentence.Split(' ');

//var querySyntax = from soz in sozlar
//                  group soz.ToUpper() by soz.Length into gr
//                  orderby gr.Key
//                  select new { Length = gr.Key, Sozlar = gr };
//foreach (var obj in querySyntax)
//{
//    Console.WriteLine("Sozlarning uzunligi: {0} xonali", obj.Length);
//    foreach(var soz in obj.Sozlar)
//    {
//        Console.WriteLine(soz);
//    }
//}
//var methodSyntax = sozlar.GroupBy(w => w.Length, w => w.ToUpper())
//                         .Select(g => new { Length = g.Key, Sozlar = g })
//                         .OrderBy(o => o.Length);
//foreach(var obj in methodSyntax)
//{
//    Console.WriteLine("Words of length: {0}", obj.Length);
//    foreach(var soz in obj.Sozlar)
//    {
//        Console.WriteLine(soz);
//    }
//}

//int[] raqamlar = { 32, 0, 1, 3, 7, 4, 5, -9, 2, 1, -4, 23, 78, 12, 32 };
//var sorov = raqamlar.OrderBy(x => x).ToArray();
//Array.ForEach(sorov, s => Console.WriteLine(s));

//Console.WriteLine();

//var surov2 = raqamlar.OrderByDescending(x => x).ToArray();
//Array.ForEach(surov2, s => Console.WriteLine(s));

//var query = from raqam in raqamlar
//            orderby raqam
//            select raqam;
//foreach(var item in query)
//    Console.WriteLine(item);

//var query2 = from raqam in raqamlar
//             orderby raqam descending
//             select raqam;

//foreach (var item in query2)
//    Console.WriteLine(item);

string[] sozlar = {"the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};

var query = sozlar.OrderByDescending(s => s.Length).ThenBy(w => w.Substring(0, 1));

foreach(var item in query)
{
    Console.WriteLine(item);
}

var query2 = from w in sozlar
             orderby w.Length descending, w.Substring(0, 1)
             select w;
foreach(var item in query)
    Console.WriteLine(item);

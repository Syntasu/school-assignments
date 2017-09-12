﻿using System;
using static System.Console;

namespace ProgrammerenHuiswerk
{
    public class Week4
    {
        private Random rand = new Random();

        public Week4()
        {
            WriteLine("--- WEEK 4 OPGAVE 1.1 en 1.2 ---\n");
            Opgave1_1And1_2("nederland");
            Opgave1_1And1_2("engeland");

            WriteLine("--- WEEK 4 OPGAVE 1.3, 1.4 en 1.5---\n");
            Opgave1_3And1_4And1_5(0, 100);
            Opgave1_3And1_4And1_5(0, rand.Next(0, 10000));
            Opgave1_3And1_4And1_5(9, 15);

            WriteLine("--- WEEK 4 OPGAVE 1.6---\n");
            string sentence = "This is a short sentence";
            string lorum_ipsum_short = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ac purus aliquam, venenatis orci in, gravida tortor. In convallis est sed pharetra scelerisque. Duis bibendum sed leo sed dapibus.";
            string lorum_ipsum_paragraph = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent ac purus aliquam, venenatis orci in, gravida tortor. In convallis est sed pharetra scelerisque. Duis bibendum sed leo sed dapibus. Vivamus cursus justo a tortor imperdiet dignissim. Aenean non purus sem. Maecenas sodales, mi nec finibus gravida, lacus mi tristique ex, ultricies consectetur mi lacus eu lacus. Aenean accumsan, nisl vitae commodo aliquet, nunc arcu semper orci, at laoreet lorem nulla quis tortor. Ut vehicula ut nulla nec lobortis. Aenean feugiat, sapien id dictum ultrices, lectus felis aliquam turpis, nec sollicitudin libero tortor a turpis. Aliquam vitae accumsan ligula, sit amet sollicitudin magna. Aenean interdum volutpat mauris, ut hendrerit ante malesuada eget. Vestibulum quis tortor ut lectus venenatis condimentum eu eget ex. Praesent non arcu enim. Nunc interdum sagittis lorem, quis varius nibh euismod vulputate.";
            string lorum_ipsum_20_paragraphs = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus non viverra velit. Proin vitae tincidunt lorem, vitae imperdiet lacus. Pellentesque eu est mollis, tempor mi ut, posuere enim. Ut consequat ante sed augue porta mattis eu sollicitudin risus. Ut dictum ipsum dui, a finibus tortor cursus vel. Donec non placerat arcu. Cras tellus mi, imperdiet ac neque nec, porta posuere velit. Curabitur ut quam ornare, cursus sem quis, gravida nisl. Nam vestibulum tellus nec nibh tristique, a faucibus elit dictum. Morbi elementum in nibh id varius. Nunc vulputate hendrerit aliquam. Proin sit amet est rhoncus ex ornare congue. Nam aliquet pharetra massa, vel pulvinar nulla eleifend finibus. Fusce in vulputate eros. Nulla sed risus ut justo commodo condimentum. Donec non nibh vel orci hendrerit pellentesque tincidunt non ex. Aliquam lobortis non nisl at malesuada. Nullam et vehicula ante. Nullam auctor in odio eu tempus.Cras id varius sapien, vel eleifend urna. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Aliquam ut lectus ac metus fermentum egestas ut et magna. Integer nec mauris ipsum. Etiam mollis mattis diam, eget mollis ante convallis sit amet.Pellentesque lorem lectus, euismod vitae orci in, venenatis semper tortor.Ut rhoncus urna sapien, convallis tincidunt nisi auctor a. Phasellus ipsum massa, gravida vel dictum ut, rhoncus ac mauris. Sed at rutrum risus. Suspendisse elit tortor, hendrerit et odio et, scelerisque porta dolor. Praesent nec ornare velit. Maecenas lectus nisl, rhoncus sed tincidunt non, bibendum id libero. Morbi tincidunt ante lacus, placerat hendrerit leo interdum nec. Etiam quis lectus et augue sodales auctor eu vel tellus. Nunc nec vulputate justo, ac commodo lorem. Nunc eleifend erat eu purus commodo tincidunt.Integer efficitur vulputate massa quis egestas. Etiam vitae leo volutpat, imperdiet massa a, dignissim nisi.Suspendisse metus tellus, iaculis quis feugiat eu, cursus sed neque. Suspendisse non libero in nisl fringilla tempor.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Vivamus facilisis condimentum risus, dapibus placerat ante imperdiet non. Morbi viverra, orci sed scelerisque pulvinar, erat felis luctus nulla, non rhoncus nulla lorem sed ipsum.Morbi pharetra id justo eu tempor. Pellentesque a quam arcu. Curabitur hendrerit at nisl vitae suscipit. Nunc efficitur molestie elit in tristique.Sed mauris orci, maximus ut turpis non, sollicitudin sollicitudin mi. Duis lacus nulla, iaculis sed quam id, euismod porttitor metus. Integer ultrices semper eros, eu semper lorem scelerisque et. Phasellus iaculis dui posuere, lacinia sem ut, efficitur quam.Nulla ac quam at elit pretium blandit.Suspendisse sed tincidunt nisl, ut mattis orci. Praesent non justo mauris. Etiam vel arcu non ex vestibulum finibus et nec orci. Donec ullamcorper lacus sed sagittis mattis. Praesent hendrerit lacus vitae elit imperdiet, at gravida ex venenatis.Nunc tristique ligula ac libero scelerisque, ac sollicitudin metus placerat.Nam pellentesque interdum commodo. Sed vestibulum, est nec feugiat aliquam, est metus rutrum odio, nec luctus nisl arcu sit amet ex. Nullam rutrum cursus consequat. Quisque sit amet accumsan tellus, id tempus tortor.Nam condimentum elementum quam, id consequat enim sagittis quis. Pellentesque ornare, ante ut congue aliquam, augue odio lacinia ipsum, et molestie nibh dui a arcu.Quisque in justo vitae lectus consequat auctor sed ut dui. Etiam dignissim massa in ligula dictum, eu sagittis lacus scelerisque.In pulvinar dolor sapien, quis interdum velit pharetra quis. Vivamus in massa est. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nullam non euismod magna, id elementum diam. Curabitur convallis ligula nec metus mollis, in consequat velit pellentesque.Etiam ornare risus a arcu facilisis, at efficitur libero bibendum.Donec ac est massa. Sed sed placerat enim. Nam ultrices dictum diam et ornare. Nunc volutpat eu dui a efficitur. Aliquam vestibulum enim vel nunc vehicula varius id quis diam. Nunc volutpat felis lacus, sit amet blandit nisl egestas at.Vivamus tristique euismod erat eu laoreet. Integer aliquam quis nunc at tincidunt. Suspendisse accumsan arcu nec malesuada imperdiet.Morbi vehicula pharetra nunc, a iaculis ante mollis a. Quisque a quam augue. Quisque et bibendum leo. Curabitur id risus nec odio semper fermentum nec eu erat. Ut ante lacus, euismod non eros vel, molestie gravida mi. Aenean sit amet gravida arcu, sit amet elementum velit. Nulla lectus nisi, congue ac vulputate eu, egestas quis ante. Nunc ultricies odio at risus porttitor convallis.Aenean iaculis tempor condimentum. Aliquam erat volutpat.Cras maximus felis quam, at vestibulum sapien vestibulum a. Sed volutpat feugiat ultricies. Aliquam magna nulla, fringilla sed finibus quis, sagittis sit amet nunc.Donec in sodales ex.Quisque nec odio tristique, porta purus vitae, pulvinar massa.Quisque ornare eros urna, et vehicula erat rutrum non. In lacinia, sem quis feugiat mattis, neque nunc iaculis sem, a dignissim metus ex vel libero.Morbi facilisis nec enim at ultricies. Maecenas libero mi, ullamcorper ac vehicula tempor, convallis sit amet ligula.Pellentesque varius urna at quam dignissim, id tempor purus pharetra.Phasellus sem justo, porttitor a placerat vitae, fringilla at metus. Maecenas lacinia turpis id lorem tincidunt cursus.Ut at hendrerit eros.7Etiam sit amet libero et enim molestie interdum eu at dui.Phasellus iaculis vel erat sed facilisis. Aenean vehicula bibendum mauris, at dapibus metus dapibus et. Etiam vestibulum diam non erat auctor eleifend.Sed pulvinar, dui nec accumsan sodales, dolor lorem feugiat mi, id luctus leo neque id nulla.Nulla facilisi. Integer vel efficitur justo. Quisque lobortis arcu non ligula rutrum, vel scelerisque enim dapibus.Proin in nisi nec ipsum fringilla malesuada.Pellentesque non dolor elit. Fusce fermentum diam scelerisque, sollicitudin ligula quis, rutrum velit.Nulla commodo vulputate leo et ultrices. Proin ac libero bibendum, pulvinar arcu ut, egestas magna.Aenean finibus velit lectus, dictum convallis velit fermentum ut. Nulla tempus, risus vitae congue interdum, odio urna blandit nunc, nec tempus turpis nunc sed purus.Sed nisl est, placerat sit amet egestas vel, auctor eu justo.Sed viverra tristique orci, eu posuere velit dignissim et. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nam venenatis tristique odio. Proin semper tellus nec imperdiet mattis. Sed nec justo id nisi sollicitudin maximus.Proin mattis elit ac metus pharetra, sit amet condimentum metus pulvinar. Sed ligula lorem, elementum non imperdiet quis, iaculis non quam.Donec viverra interdum malesuada. Quisque efficitur lorem ipsum, vel viverra enim dignissim sed. Maecenas at consectetur orci, et efficitur ex. Suspendisse convallis sapien ut diam dapibus dapibus.Morbi vulputate condimentum velit eu venenatis. Donec sed pretium enim. Duis accumsan felis porta, consectetur ligula non, maximus quam.Pellentesque vitae vestibulum risus, sed volutpat tortor. Pellentesque sit amet ultricies orci, a congue felis.Fusce sagittis velit tortor, vitae blandit purus iaculis ac. Nullam tincidunt nisl vitae nisi eleifend elementum.Praesent in porttitor sem, sed iaculis quam. Phasellus commodo cursus est, feugiat facilisis lorem convallis sit amet.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Donec vel odio in magna vestibulum sollicitudin.Aliquam ac erat odio. In hac habitasse platea dictumst.Fusce vestibulum ex bibendum, vulputate erat consectetur, consequat metus.Integer aliquet, lorem eget gravida tristique, est eros efficitur sapien, id efficitur sapien felis ac orci.Aliquam erat volutpat.Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Curabitur efficitur nulla nulla.Donec varius mattis felis ut malesuada. Donec vel lacus semper, ornare lorem et, tempus dui.Aenean mattis ante libero, vel consectetur est tempor sed. Vestibulum malesuada interdum enim, auctor eleifend quam aliquam et. Vestibulum id nunc purus. Curabitur tempor pharetra turpis in vulputate.Phasellus ac risus eu ex lobortis fringilla vel sit amet ex.Quisque imperdiet odio lacus, in venenatis metus ornare ac. Etiam tempor a nunc a congue. Sed nunc augue, mattis et bibendum eget, scelerisque vitae neque. Praesent viverra tortor nisl. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae;Nunc volutpat fringilla volutpat. Aliquam eu ex metus. Donec tortor neque, dictum eget augue nec, gravida sagittis risus. Donec congue placerat felis vitae luctus. Proin efficitur vehicula odio, lacinia tempus nisi ullamcorper eu. Fusce ac neque pharetra, dignissim massa id, rhoncus erat.Lorem ipsum dolor sit amet, consectetur adipiscing elit.Proin quis tincidunt turpis. In auctor metus sed urna mollis cursus.Praesent volutpat ante eget urna fringilla consequat.Suspendisse sed ullamcorper magna, semper ultricies libero.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.In feugiat, nisl vel fringilla volutpat, mauris quam porttitor ligula, ut accumsan nisi quam non tellus.Mauris fermentum nec augue et malesuada. Donec aliquet urna eget tellus bibendum, sed cursus nisl pretium.Sed sed odio porttitor, sagittis nulla sed, fringilla sapien.Nullam tincidunt, nibh a elementum rhoncus, neque enim tristique ligula, vel semper metus tortor non massa.Mauris dapibus, felis non gravida feugiat, tellus massa laoreet tortor, non dignissim quam tortor in nisi.Cras cursus risus dui, ut mollis velit mollis sit amet.Integer mi odio, rutrum eget augue quis, feugiat gravida odio. Fusce gravida est id augue convallis, ut condimentum magna efficitur.Nulla euismod ultrices nunc, et egestas erat ullamcorper eget. Ut in orci a orci vestibulum porttitor.Nam vehicula ante quis luctus iaculis. Sed at ante eros. Sed ut urna cursus nulla ultrices varius.Praesent vel quam dictum, eleifend velit eget, blandit lorem.Vivamus ligula felis, maximus eget sollicitudin id, elementum vel tortor. Sed ut lectus sollicitudin risus faucibus ornare.Vivamus facilisis ligula erat, id lacinia ante interdum ac. Quisque commodo vitae eros non convallis. Nulla est massa, tristique id lacus nec, varius convallis libero. Donec tincidunt imperdiet mollis. Nullam ut sodales odio.Donec lobortis lectus ante, ac luctus tellus congue id. Phasellus imperdiet varius justo, in suscipit est. Nam erat nibh, pulvinar a fermentum et, lacinia suscipit ex. Curabitur lacus lectus, bibendum in leo vel, bibendum volutpat leo. Fusce nunc metus, fermentum at arcu vel, ornare laoreet neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Integer sit amet enim ut metus aliquam suscipit. Donec non pellentesque risus, nec iaculis nisl. Cras auctor tortor in dapibus faucibus. Proin rhoncus laoreet accumsan. Nullam congue condimentum sodales. Phasellus quis risus non leo faucibus porttitor.Proin sed dui libero. Aenean ullamcorper, diam at eleifend sodales, nibh neque aliquet purus, a vehicula purus nisi vitae lorem.Maecenas porta porttitor justo eu vulputate. Ut placerat interdum orci nec iaculis. Sed fringilla mollis erat, a elementum eros laoreet at. Nam elit lorem, rutrum et est vitae, faucibus ullamcorper enim. Suspendisse faucibus volutpat odio, ac scelerisque nibh mollis non. Etiam feugiat mi ac eros convallis facilisis.Proin tempor semper turpis quis fringilla. Praesent nec orci nec nisi aliquam egestas quis eu mi. In nunc dolor, placerat quis blandit a, venenatis non urna. Sed aliquam porta sapien vel feugiat. Nunc sagittis tellus sit amet lacinia mattis.Fusce ut posuere mauris. Vivamus nisi leo, feugiat accumsan cursus suscipit, vehicula sodales nibh. Cras tempus risus mauris, ac laoreet nisl tincidunt eu. Aliquam erat volutpat.Donec rhoncus ipsum id ultricies venenatis. Cras tincidunt dignissim mollis. Curabitur at libero feugiat, mollis purus ut, varius metus.Pellentesque ornare bibendum mauris, et consequat ipsum porttitor congue. Vestibulum laoreet commodo rutrum. Integer vel porta enim, semper convallis felis. Quisque eu semper felis. Fusce sed congue felis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Vivamus ut tortor sagittis, egestas ligula sit amet, dignissim lectus. Nullam sed libero mauris. Nulla pretium ullamcorper felis vitae pulvinar. Aliquam aliquam convallis neque. Ut congue fermentum tellus sed ultrices. Sed et est tincidunt, pulvinar orci ut, mattis libero.";

            Opgave1_6(sentence);
            Opgave1_6(lorum_ipsum_short);
            Opgave1_6(lorum_ipsum_paragraph);
            Opgave1_6(lorum_ipsum_20_paragraphs);

            WriteLine("--- WEEK 4 OPGAVE 2.1---\n");
            Opgave2_1();


            WriteLine("--- WEEK 4 OPGAVE 2.2, 2.3, 2.4, 2.5 en 2.6---\n");
            Opgave2_2To2_6();
        }

        public void Opgave1_1And1_2(string input)
        {

            string result = input;
            if (input.Length % 2 != 0)
            {
                result = input.Substring(input.Length / 2, 1);
            }
            else
            {
                result = input.Substring((input.Length / 2) - 1, 2);
            }

            WriteLine($"The middle letter(s) of {input} is {result}");
            WriteLine();
        }

        public void Opgave1_3And1_4And1_5(int m, int n)
        {
            int sum = (n - m + 1) * (n + m) / 2;
            WriteLine($"The sum of {m} to {n} is {sum}");
        }

        public void Opgave1_6(string text)
        {
            string[] textSplit = text.Split(' ');
            WriteLine($"The given text has {textSplit.Length} amount of words");
        }

        public void Opgave2_1()
        {
            string word1 = "Hello";
            string word2 = "World";

            WriteLine($"The third character of {word1} is {ThirdLetter(word1)}");
            WriteLine($"The third character of {word2} is {ThirdLetter(word2)}");
        }

        public void Opgave2_2To2_6()
        {
            int index1 = 3;
            string word1 = "Trains";

            int index2 = 4;
            string word2 = "Boats";

            WriteLine($"The character at {index1} of {word1} is {LetterN(word1, index1)}");
            WriteLine($"The character af {index2} of {word2} is {LetterN(word2, index2)}");

            /*
             4. Wat gebeurt er als je de waarde 0, of kleiner dan 0 meegeeft?
                Index out of bounds exception, omdat de index niet bestaat in de string.

             5. Wat gebeurt er als je een waarde opgeeft die groter is dan de lengte
              van de tekst?
                Index out of bounds exception, omdat de index niet bestaat in de string.
             */

            WriteLine();
            string word3 = "Auto";
            for (int i = -word3.Length; i < word3.Length * 2; i++)
            {
                char fetched = LetterNSafe(word3, i);

                if (fetched != (char)0)
                {
                    WriteLine($"The character at {i} of {word3} is {LetterNSafe(word3, i)}");
                }
                else
                {
                    WriteLine($"Index {i} is not a valid index");
                }
            }
        }

        private char ThirdLetter(string word)
        {
            return word[2];

        }

        private char LetterN(string word, int index)
        {
            return word[index - 1];
        }

        private char LetterNSafe(string word, int index)
        {
            if (index <= 0 || index > word.Length) return (char)0;
            return word[index - 1];
        }
    }
}

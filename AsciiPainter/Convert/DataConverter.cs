using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiPainter.Convert
{
    public class Letter
    {
        public char StandartLetter { get; private set; }
        public string ASCII { get; private set; }

        public Letter(char letter, string ascii)
        {
            this.StandartLetter = letter;
            this.ASCII = ascii;
        }
    }
    public class DataConverter
    {

        public static Letter[] Data1 = new Letter[]
        {
            new Letter('a', "╔══╗\r\n║╔╗║\r\n║╚╝║\r\n║╔╗║\r\n║║║║\r\n╚╝╚╝\r\n"),
            new Letter('b', "╔══╗─\r\n║╔╗║─\r\n║╚╝╚╗\r\n║╔═╗║\r\n║╚═╝║\r\n╚═══╝\r\n"),
            new Letter('c', "╔══╗\r\n║╔═╝\r\n║║──\r\n║║──\r\n║╚═╗\r\n╚══╝\r\n"),
            new Letter('d', "╔══╗─\r\n║╔╗╚╗\r\n║║╚╗║\r\n║║─║║\r\n║╚═╝║\r\n╚═══╝\r\n"),
            new Letter('e', "╔═══╗\r\n║╔══╝\r\n║╚══╗\r\n║╔══╝\r\n║╚══╗\r\n╚═══╝\r\n"),
            new Letter('f', "╔══╗\r\n║╔═╝\r\n║╚═╗\r\n║╔═╝\r\n║║──\r\n╚╝──\r\n"),
            new Letter('g', "╔═══╗\r\n║╔══╝\r\n║║╔═╗\r\n║║╚╗║\r\n║╚═╝║\r\n╚═══╝\r\n"),
            new Letter('h', "╔╗╔╗\r\n║║║║\r\n║╚╝║\r\n║╔╗║\r\n║║║║\r\n╚╝╚╝\r\n"),
            new Letter('i', "╔══╗\r\n╚╗╔╝\r\n─║║─\r\n─║║─\r\n╔╝╚╗\r\n╚══╝\r\n"),
            new Letter('j', "─╔══╗\r\n─╚╗╔╝\r\n──║║─\r\n╔╗║║─\r\n║╚╝╚╗\r\n╚═══╝\r\n"),
            new Letter('k', "╔╗╔══╗\r\n║║║╔═╝\r\n║╚╝║──\r\n║╔╗║──\r\n║║║╚═╗\r\n╚╝╚══╝\r\n"),
            new Letter('l', "╔╗──\r\n║║──\r\n║║──\r\n║║──\r\n║╚═╗\r\n╚══╝\r\n"),
            new Letter('m', "╔╗──╔╗\r\n║║──║║\r\n║╚╗╔╝║\r\n║╔╗╔╗║\r\n║║╚╝║║\r\n╚╝──╚╝\r\n"),
            new Letter('n', "╔╗─╔╗\r\n║╚═╝║\r\n║╔╗─║\r\n║║╚╗║\r\n║║─║║\r\n╚╝─╚╝\r\n"),
            new Letter('o', "╔══╗\r\n║╔╗║\r\n║║║║\r\n║║║║\r\n║╚╝║\r\n╚══╝\r\n"),
            new Letter('p', "╔═══╗\r\n║╔═╗║\r\n║╚═╝║\r\n║╔══╝\r\n║║───\r\n╚╝───\r\n"),
            new Letter('q', "╔═══╗\r\n║╔═╗║\r\n║║─║║\r\n║║╔╝║\r\n║╚╝─║\r\n╚═══╝\r\n"),
            new Letter('r', "╔═══╗\r\n║╔═╗║\r\n║╚═╝║\r\n║╔╗╔╝\r\n║║║║─\r\n╚╝╚╝─\r\n"),
            new Letter('s', "╔══╗\r\n║╔═╝\r\n║╚═╗\r\n╚═╗║\r\n╔═╝║\r\n╚══╝\r\n"),
            new Letter('t', "╔════╗\r\n╚═╗╔═╝\r\n──║║──\r\n──║║──\r\n──║║──\r\n──╚╝──\r\n"),
            new Letter('u', "╔╗╔╗\r\n║║║║\r\n║║║║\r\n║║║║\r\n║╚╝║\r\n╚══╝\r\n"),
            new Letter('v', "╔╗╔╗\r\n║║║║\r\n║║║║\r\n║╚╝║\r\n╚╗╔╝\r\n─╚╝─\r\n"),
            new Letter('w', "╔╗╔╗╔╗\r\n║║║║║║\r\n║║║║║║\r\n║║║║║║\r\n║╚╝╚╝║\r\n╚═╝╚═╝\r\n"),
            new Letter('x', "╔══╗╔══╗\r\n╚═╗║║╔═╝\r\n──║╚╝║──\r\n──║╔╗║──\r\n╔═╝║║╚═╗\r\n╚══╝╚══╝\r\n"),
            new Letter('y', "╔╗╔╗\r\n║║║║\r\n║╚╝║\r\n╚═╗║\r\n─╔╝║\r\n─╚═╝\r\n"),
            new Letter('z', "╔═══╗\r\n╚═╗─║\r\n─╔╝╔╝\r\n╔╝╔╝─\r\n║─╚═╗\r\n╚═══╝\r\n"),
            new Letter(' ', "──\r\n──\r\n──\r\n──\r\n──\r\n──\r\n"),
        };
    }
}

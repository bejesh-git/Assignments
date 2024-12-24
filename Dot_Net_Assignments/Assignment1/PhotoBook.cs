using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesCsharp
{
    internal class PhotoBook
    {
        private int numPages;
        
        public int Numpages
        {
            set { this.numPages = value; }
            get { return this.numPages; }
        }

        public PhotoBook()
        {
            Numpages = 16;
        }
        public PhotoBook(int numPages)
        {
            Numpages = numPages;
        }

        public int GetNumberPages()
        {
            return Numpages;
        }
    }


    internal class BigPhotoBook : PhotoBook
    {
        

        public BigPhotoBook()
        {
            Numpages = 64;
        }

    }
}

using System;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length != 1 ) 
            {
                Console.WriteLine( "Incorrect number of arguments!" + "\n" +
                    "Usage remove_duplicates.exe < input string >" );
                Environment.Exit(1);
            }

            string str = args[ 0 ];

            for ( int i = 0; i < str.Length; i++ )
            {
                for ( int j = i + 1; j < str.Length; j++ )
                {
                    if ( str[ i ] == str[ j ] )
                    {
                        str = str.Remove( j, 1 );
                        j--;
                    }
                }
            }

            Console.WriteLine( str );

        }
    }
}

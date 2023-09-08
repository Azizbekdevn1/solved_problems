

static string Encrypt(string matn, int key)
{
     string ciphertext = "";

     foreach (char c in matn)
     {
          if (char.IsLetter(c))
          {
               char shifted = (char)(c + key);

               if ((char.IsLower(c) && shifted > 'z') || (char.IsUpper(c) && shifted > 'Z'))
               {
                    shifted -= (char)(26);
               }

               ciphertext += shifted;
          }
          else
          {
               ciphertext += c;
          }
     }

     return ciphertext;
}

static string Decrypt(string ciphertext, int key)
{
     string plaintext = "";

     foreach (char c in ciphertext)
     {
          if (char.IsLetter(c))
          {
               char shifted = (char)(c - key);

               if ((char.IsLower(c) && shifted < 'a') || (char.IsUpper(c) && shifted < 'A'))
               {
                    shifted += (char)(26);
               }

               plaintext += shifted;
          }
          else
          {
               plaintext += c;
          }
     }

     return plaintext;
}

string matn = "Hello world";
int key = 3;

string ciphertext = Encrypt(matn, key);

string fileName1 = "encryption.txt";
string fileName2 = "decryption.txt";

FileStream fileStream1 = File.Create(fileName1);
fileStream1.Close();
StreamWriter write1 = new StreamWriter(fileName1);
write1.WriteLine(ciphertext);
write1.Close();

string decrypted = Decrypt(ciphertext, key);

FileStream fileStream2 = File.Create(fileName2);
fileStream2.Close();
StreamWriter write2 = new StreamWriter(fileName2);
write2.WriteLine(decrypted);
write2.Close();
Console.WriteLine("Kiruvchi matn:" + decrypted);
Console.WriteLine("Shifrlangan matn:" + ciphertext);


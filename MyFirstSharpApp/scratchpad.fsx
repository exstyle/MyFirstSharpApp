open System.Linq
open System.IO


let text = "Hello, world" 
//Console.WriteLine(text.Length)
text = "Hello, world"



let greetPersone name age =
    sprintf "Hello, %s. You are %d years old" name age
    


greetPersone "Sébastien" 34


let countWords (sentence:string) = 
    let age = sentence.Split(' ').ToList().Count
    use sw = new StreamWriter("C:\\age.fsharp",false)
    sw.WriteLine(sentence)
    sw.WriteLine(sprintf ": %d" age)



countWords "Je m'appelles Sébastien, et si tu veux savoir l'age que j'ai, il va faloire écrire beaucoup de chose, n'est-ce pas ? Je ne sais meme pas comment commencer, alors il va faloir improviser !"

// See https://aka.ms/new-console-template for more information
byte left = 1;
byte right = 100;
Console.WriteLine($"загадайте число от {left} до {right}");
while (left < right) {
    byte center = (byte)(left + (right - left) / 2);

    
    Console.WriteLine($"Ваше число больше {center} ?  введите \" yes\" or \"no \"):");
    string? answer=Console.ReadLine();
    if (answer == "yes") { left =(byte) (center+1); } else if(answer=="no"){
        right = center; }
    else {
        continue;
    };
    }
Console.WriteLine($"Ваше число {right}");
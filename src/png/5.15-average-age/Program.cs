// Here we define the total age of famous computers scientists.
// ie. how old they were when they died.
double ada_lovelace = 36.0;
double dennis_ritchie = 70.0;
double grace_hopper = 85.0;
double hedy_lamarr = 85.0;
double edsger_dijkstra = 72.0;
double douglas_engelbart = 88.0;

double female_avg = (ada_lovelace + grace_hopper + hedy_lamarr) / 3;
double male_avg = (dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
double avg = (male_avg + female_avg) / 2;
double diff = male_avg - female_avg;

Console.WriteLine("Average lifespan of a male computer scientist: {0}", male_avg);
Console.WriteLine("Average lifespan of a female computer scientist: {0}", female_avg);
Console.WriteLine("Average lifespan of a computer scientist: {0}", avg);
Console.WriteLine("Males live this much longer than females: {0}", diff);

/*
This program calculates the average lifespans of male computer scientists, using three data points, namely the
age at death for Dennis Ritchie, Edsger Dijkstra and Douglas Engelbart.
then it does the same exact thing for female computer scientists using the
age at death for Ada Lovelace, Grace Hopper and Hedy Lamarr.

Then it calculates the average lifespan of computer scientists (using the two averages, irregardless of gender)
and finally it outputs how long male computer scientists live compared to female computer scientists.
All the data is a result of simple arithmetic (taking averages, calculating difference and adding two averages together then averaging that)
*/
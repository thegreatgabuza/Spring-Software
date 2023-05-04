using System;

class Program {
  public static void Main (string[] args) {
// Spring rate. 
   double Fo, Fi, Lo, k;
    float Li;
        Console.Write("Enter F(o) (Newtons): ");
        Fo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter mean F(i) (Newtons): ");
        Fi = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter L(o): ");
        Lo = Convert.ToDouble(Console.ReadLine());

     Console.Write("Enter L(i): ");
        Li =  float.Parse(Console.ReadLine());


        k = (Fo -Fi) / (Lo - Li);

        Console.WriteLine("Spring rate (k) = {0:N2} N/m", k);

    // Wire diameter

       // Define the constant value of kW
        const double kW = 1.2;

        // Ask the user to enter the values of F, D, and tau
        Console.Write("Enter the force (F): ");
        double F = double.Parse(Console.ReadLine());

        Console.Write("Enter the mean coil diameter (D): ");
        double D = double.Parse(Console.ReadLine());

        Console.Write("Enter the shear stress (tau): ");
        double tau = double.Parse(Console.ReadLine());

        // Calculate the wire diameter using the formula
        double d = Math.Pow((8 * F * D * kW) / (Math.PI * tau), 1.0/3.0);

        // Display the calculated wire diameter
        Console.WriteLine("The wire diameter is: " + d);


    //spring index
    double  C;

    // Ask user to insert table diameter = dt from the table
    Console.Write("Enter table diameter (dt)");
    double dt = double.Parse(Console.ReadLine());

    
    C = D/ dt;
   Console.WriteLine("The spring index is" + C );



    //Calculated wahl factor denoted by cKw
    
     double ckw = (4*C - 1)/(4*C - 4) + (0.615/C);
     Console.WriteLine("The Calculated Wahl Factor is" + ckw );


    //Shear stress max
double tau_max = (8 * ckw * F * D) / (Math.PI * Math.Pow(dt, 3));
Console.WriteLine("The shear max is" + tau_max);

// calculating number of active coils
 
   Console.Write("Enter Modulus of rigidity (G)"); 
     double G = double.Parse(Console.ReadLine());
    
double Na = (G * dt) / (8 * k * Math.Pow(C, 3));
    Console.WriteLine("The number of active coils is" + Na);


  // Body Lenght

    double lb = dt*(Na+1);
Console.WriteLine("Body Length is equal to" + lb);

// Inner Diameter

    double Di = D - dt;
    Console.WriteLine("Inner Diameter is equal to" + Di);
    
// Outer Diameter
      double Do = D + dt;
    Console.WriteLine("Outer Diameter is equal to" + Do);
    
// Free Lenght

    double Lf = (lb + 2 * Di);
     Console.WriteLine("Free Lenght is equal to" + Lf);

// Deflection

    double Deflection = Lo - Lf;
     Console.WriteLine("Deflection is equal to" + Deflection);

// Initial Force

    double fInitial = Fo - (k * Deflection);
     Console.WriteLine("Initial Force is equal to" + fInitial);
    }

  
}
using Shapes;
using System;

namespace Shapes3D {

    public abstract class Shape3D {
        public abstract double GetVolume();
        public abstract double GetSureFaceArea();
    }

    class Cuboid : Shape3D 
    {
        public double legnth;
        public double height;
        public double depth;

        static double Cuboid_Volume(double length, double height, double depth) 
        {
            return length * height * depth;
        }

        public override double GetVolume() 
        {
            return Cuboid_Volume(this.legnth, this.height, this.depth);
        }
    
        static override double Cuboid_SureFaceArea(double length, double height, double depth) 
        {
            return (4 * (length * height)) + (2 * (height * depth));
        }
        public override double GetSureFaceArea() 
        {
        return Cuboid_SureFaceArea(this.legnth, this.height, this.depth);
        }
    }

    class Cube : Shape3D 
    {
        public double legnth;

        static double Cube_Volume(double length) 
        {
            return Math.Pow(length, 3);
        }

        public override double GetVolume() 
        {
            return Cube_Volume(this.legnth);
        }
    
        static override double Cube_SureFaceArea(double length) 
        {
            return 6 * (Math.Pow(length, 2));
        }
        public override double GetSureFaceArea() 
        {
            return Cube_SureFaceArea(this.legnth);
        }
    }

    class Cylinder : Shape3D 
    {
        public double radius;
        public double height;

        static double Cylinder_Volume(double radius, double height) 
        {
            
            return (2 * (Math.Pow(Math.PI, 2)) * radius) ;
        }

        public override double GetVolume() 
        {
            return Cylinder_Volume(this.radius, this.height) ;
        }
    
        static override double Cylinder_SureFaceArea(double radius, double height)
        {
         return (2 * Math.PI * radius * height) + (P2 * Math.Pi * Math.Pow(radius, 2)) ;
        }
        public override double GetSureFaceArea() 
        {
            return Cylinder_SureFaceArea(this.radius, this.height) ;
        }
    }
    class Sphere : Shape3D 
    {
        public double radius;

        static double Sphere_Volume(double radius) 
        {
            return 4 * Math.PI * (Math.Pow(radius, 2)) ;
        }

        public override double GetVolume() 
        {
            return Sphere_Volume(this.radius);
        }
    
        static override double Sphere_SureFaceArea(double radius, double height)
        {
         return (4/3) * Math.PI * (Math.Pow(radius, 3));
        }
        public override double GetSureFaceArea() 
        {
            return Sphere_SureFaceArea(this.radius);
        }
    }   

     class N_Gonal_Prism : Shape3D 
    {
        public double side_numbers;
        public double height;
        public double side_length;
        public int faces;

        static double N_Gonal_Prism(double side_numbers, double height, double side_length, int faces) 
        {
            
            Polygon_BaseArea = (1/2) * side_length * ((side_length/2) * Math.Sqrt(3)) * sides_numbers;
            
            return (Polygon_BaseArea * height);
        }

        public override double GetVolume() 
        {
            return N_Gonal_Prism(this.side_numbers, this.height, this.side_length, this.faces);
        }
    
        static override double N_Gonal_Prism(double side_numbers, double height, double side_length, int faces)
        {
            Polygon_BaseArea = (1/2) * side_length * ((side_length/2) * Math.Sqrt(3)) * sides_numbers;
            return (side_length * height) * side_numbers + (faces * Polygon_baseArea);
        }
        public override double GetSureFaceArea() 
        {
            return N_Gonal_Prism(this.side_numbers, this.height, this.side_length, this.faces);
        }
    }      
}

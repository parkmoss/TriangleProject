using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesProject
{
    public class Triangle
    {
        private string[] sideTypes = new string[] { "equilateral", "isosceles", "scalene" };

        // Allows us to check only for numbers while providing an error message if it's not a number
        // (if type was float instead of string the entered value of a string would not be put into field giving us no error message)
        [Required(ErrorMessage = "Side A length is required.")]
        [RegularExpression("([0-9.-])*", ErrorMessage = "Please enter a valid number.")]
        public string sideA { get; set; }

        private float _sideA { get { return float.Parse(sideA); } }

        [Required(ErrorMessage = "Side B length is required.")]
        [RegularExpression("([0-9.-])*", ErrorMessage = "Please enter a valid number.")]
        public string sideB { get; set; }
        private float _sideB { get { return float.Parse(sideB); } }

        [Required(ErrorMessage = "Side C length is required.")]
        [RegularExpression("([0-9.-])*", ErrorMessage = "Please enter a valid number.")]
        public string sideC { get; set; }

        private float _sideC { get { return float.Parse(sideC); } }

        private List<float> sides
        {
            get
            {
                try
                {
                    return new List<float> { _sideA, _sideB, _sideC };
                }
                catch
                {
                    throw new Exception("Triangles sides must be entered.");
                }
            }
        }

        public string sideType 
        { 
            get 
            {
                try
                {
                    // Gives the distinct amount of sides which we can subtract one from to get the correct side type from our array
                    return sideTypes[sides.Distinct().Count() - 1];
                }
                catch
                {
                    throw new Exception("Triangles sides must be entered to calculate it's side type.");
                }
            } 
        }

        public float angleA 
        { 
            get 
            {
                try
                {
                    return TriangleMath.lawOfCosines(_sideB, _sideC, _sideA);
                }
                catch
                {
                    throw new Exception("Triangles sides must be entered to calculate angle A.");
                }
            }
        }

        public float angleB 
        { 
            get
            {
                try 
                { 
                    return TriangleMath.lawOfCosines(_sideC, _sideA, _sideB);
                }
                catch
                {
                    throw new Exception("Triangles sides must be entered to calculate angle B.");
                }
            }
        }

        // Used Law of Cosines to make third angle more precise than 180 - sideA - sideB
        public float angleC 
        {
            get
            {
                try 
                {
                    return TriangleMath.lawOfCosines(_sideA, _sideB, _sideC);
                }
                catch
                {
                    throw new Exception("Triangles sides must be entered to calculate angle C.");
                }
            }
        }

        private float[] angles 
        { 
            get 
            { 
                return new float[] { angleA, angleB, angleC }; 
            } 
        }

        public string angleType 
        { 
            get 
            {
                if (angles.Any(a => a > 90)) return "obtuse";
                else if (angles.Any(a => a == 90)) return "right";
                else return "acute";
            } 
        }

        public string triangleType
        {
            get
            {
                return $"{angleType} {sideType}";
            }
        }

        public bool ValidTriangle()
        {
            List<float> sidesCopy = new List<float>(sides);
            sidesCopy.Sort();

            // Check if lowest two values will be greater than highest value to check if real triangle
            if (sidesCopy[0] + sidesCopy[1] > sidesCopy[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class TriangleMath
    {
        // Law of Cosines gets triangle angles from sides
        public static float lawOfCosines(float side1, float side2, float sideOppositeAngle)
        {
            double resultInRadians = Math.Acos(
                        (Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(sideOppositeAngle, 2)) / (2 * side1 * side2)
                );
            // Changes result to degrees instead of radians
            return (float)Math.Round(resultInRadians * 180 / Math.PI, 3);
        }
    }
}

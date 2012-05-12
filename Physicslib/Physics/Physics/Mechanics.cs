using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Physics
{
    static class Constants
    {
        public const double gravity = 9.81;
        public const double Pi = 3.14159265359;
        public const int lightSpeed = 300000; // km/s
    }


    public class Mechanics
    {

        
        //Calculate velocity from displacement and time
        public double velocity(double displacement, double time)
        {
            return displacement / time;
        }
        //Calculate average velocity from distance change and time change
        public double avVelocity(double distChange, double timeChange)
        {
            return distChange / timeChange;
        }
        //Calculate acceleration from velocity change and time
        public double acceleration(double chanVelocity, double time)
        {
            return chanVelocity / time;
        }
        //Calculate linear acceleration from initial speed and end speed
        public double linearAcceleration(double iniSpeed, double speed)
        {
            return (iniSpeed + speed) / 2;
        }
        //Calculate fall speed from initial speed upwards and time
        public double freeFall(double iniSpeed, double time)
        {
            return iniSpeed - Constants.gravity * time;
        }
        //Calculate weight from mass (based on Newton II)
        public double Weight(double mass)
        {
            return mass * Constants.gravity;
        }
        //Calculate weight of an object in incline angle
        public double InclineAngleWeight(double mass, double angle)
        {
            return mass * Constants.gravity * Math.Sin(angle);
        }
        //Calculate potential energy from mass and height
        public double potentialEnergy(double mass, double height)
        {
            return mass * Constants.gravity * height;
        }

        /*
         *      Newton II
         *       F = ma       
         */
        public double Force(double mass, double acceleration)
        {
            return mass * acceleration;
        }

        //E = 1/2mv^2
        public double kineticEnergy(double mass, double velocity)
        {
            return mass / 2 * velocity * velocity;
        }
        

        //(2v * Sin a) / g
        public double Hangtime(double speed, double angle)
        {
            double result = -1;
            result = 2 * speed * Math.Sin(angle);
            result = result / Constants.gravity;
            return result;
        }
        //(v^2*Sin 2a) / g
        public double Range(double speed, double angle)
        {
            double result = -1;

            result = speed * speed * Math.Sin(2 * angle);
            result = result / Constants.gravity;


            return result;
        }
    }
}

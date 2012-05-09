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

        

        public double velocity(int displacement, int time)
        {
            return displacement / time;
        }

        public double avVelocity(int distChange, int timeChange)
        {
            return distChange / timeChange;
        }

        public double acceleration(int chanVelocity, int time)
        {
            return chanVelocity / time;
        }

        public double linearAcceleration(int iniSpeed, int speed)
        {
            return (iniSpeed + speed) / 2;
        }

        public double freeFall(int iniSpeed, int time)
        {
            return iniSpeed - Constants.gravity * time;
        }

        public double Weight(int mass)
        {
            return mass * Constants.gravity;
        }

        public double InclineAngleWeight(int mass, int angle)
        {
            return mass * Constants.gravity * Math.Sin(angle);
        }

        public double potentialEnergy(int mass, int height)
        {
            return mass * Constants.gravity * height;
        }

        /*
         *      Newton II
         *       F = ma       
         */
        public double Force(int mass, int acceleration)
        {
            return mass * acceleration;
        }

        //E = 1/2mv^2
        public double kineticEnergy(int mass, int velocity)
        {
            return mass / 2 * velocity * velocity;
        }
        

        //(2v * Sin a) / g
        public double Hangtime(int speed, int angle)
        {
            double result = -1;
            result = 2 * speed * Math.Sin(angle);
            result = result / Constants.gravity;
            return result;
        }
        //(v^2*Sin 2a) / g
        public double Range(int speed, int angle)
        {
            double result = -1;

            result = speed * speed * Math.Sin(2 * angle);
            result = result / Constants.gravity;


            return result;
        }
    }
}

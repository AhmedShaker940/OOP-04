namespace Assignment04OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1  Abstraction
            //a)  What is Abstraction in Object-Oriented Programming?
            /*
               Abstraction is the process of hiding the implementation details and showing only the important features for users
             */

            //b)  Why is abstraction considered one of the four pillars of OOP?

            /*
             because it makes program reduces complexity of program , make it easier and faster to maintain besides it works on the whole program (methods , classes , props)
             */
            #endregion

            #region Q2  Abstract Classes vs. Interfaces

            //a)  What is the difference between an Abstract Class and an Interface?

            /*
             - Abstract Class use keyword : abstract , Interface use keyword : Interface
             - Abstract Class can have signitures and fully implemented methods ,Interface can have both too (after C#8)
             - Abstract Class can have fields , Interface Can't have Fields (except Consts (const int x= 10;))
             - Abstract Class can use any Access Modifier (Default Access Modifier inside is Private) , Interface can only use (public , private , internal , protected) Default Access Modifier for members inside Interface is Public
             - Abstract Class's Default Access Modifier is Internal , Interface's Default Access Modifier is Internal
             - Abstract Class Can have (Fields , CTORs , Methods (Concrete or Abstract), Props) , Interfaces can only hve (Methods, Props , Indexers, Events)
             - A Class can inherit one Abstract Class, A Class can Implement more than one Interface
             */

            //b)  When would you choose an Interface instead of an Abstract Class?

            /*
             you Can use Interface over Abstract Class When u have unrelated Classes (NO Inheritance) to make A Contract Between Them 
             */

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?

            /*
             A Class Can't Inherit from Multible Classes (Multible Inheritance => Wrong) , A class can Implement Multible Interfaces => True
             */

            #endregion

            #endregion
        }
    }
}

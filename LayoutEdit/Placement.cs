using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace LayoutEdit
{
    static class Placement
    {
        internal struct HouseItem
        {
            internal Int64 ItemID;
            internal Int32 DatabaseID;
            internal decimal x;
            internal decimal z;
            internal decimal y;
            internal decimal Rotation;
            internal decimal Pitch;
            internal decimal Roll;
            internal decimal Scale;
            internal bool InCrate;
            internal string ItemName;
            internal string Memo;
        }
        
        internal struct Vector3D{
            internal double X, Y, Z;
            internal Vector3D(double X, double Y, double Z)
            {
                this.X = X;
                this.Y = Y;
                this.Z = Z;
            }
        }
        
        internal enum DirectionType
        {
            Forward = 1,
            Reverse = -1
        }
        internal enum RotateAxis
        {
            x = 1,
            y = 2,
            z = 3
        }
        /// <summary>
        /// Draws a Circle on a Plane
        /// </summary>
        /// <param name="Items">Items to include</param>
        /// <param name="CenterPoint">X Y Z Center Point of circle</param>
        /// <param name="Orientation">0 for horizontal, 1 for vertical</param>
        /// <param name="Radius">Radius</param>
        /// <param name="Facing">0 for item on North/South wall, 1 for East/West (Vertical Placement only)</param>
        /// <param name="Direction">Direction to draw (Use Reverse for best results)</param>
        /// <param name="Percentage">How much of the circle to draw</param>
        /// <param name="Rotate">Rotate items or leave orientation</param>
        /// <param name="StartDegree">Offset of starting point (0 - 360)</param>
        /// <param name="Offset90">When rotating, offset rotation by 90 degrees (adjusts rotation)</param>
        /// <param name="Spiral">Draw as Spiral</param>
        /// <param name="VertSpiral">If spiral, draw vertical spiral (False if from center)</param>
        /// <param name="Revolutions">How many times to go around the circle</param>
        /// <param name="EndZ">Ending point for vertical spiral</param>
        /// <param name="TopPoint">Point the top of items at the center of the circle (Vertical Circle)</param>
        internal static HouseItem[] CirclePlane(HouseItem[] Items, 
            Vector3D CenterPoint
            , int Orientation 
            , double Radius
            , int Facing
            , double EndZ
            , DirectionType Direction = DirectionType.Reverse
            , double Percentage = 1
            , bool Rotate = true
            , double StartDegree = 0
            , bool Offset90 = false
            , bool Spiral = false
            , bool VertSpiral = false
            , double Revolutions = 1
            , bool TopPoint = false
            )
        {
            double Arc;
            double uRadius;
            if (!Spiral)
            {
                Arc = 2d * Math.PI / ((double)Items.Count());
            } else {
                Arc = 2d * Math.PI / ((double)Items.Count() / Revolutions);
            }
            double X, Y, SD, zStep;
            for (int i = 0; Math.Abs(i) < Items.Count(); i += (int)Direction)
            {
                if (Spiral && !VertSpiral)
                {
                    uRadius = (double)Math.Abs(i) / (double)Items.Count() * Radius;
                }
                else
                {
                    uRadius = Radius;
                }
                if (Spiral && VertSpiral)
                {
                    zStep = (EndZ - CenterPoint.Z) / (double)Items.Count();
                }
                else { zStep = 0; }
                SD = StartDegree / 359 * Items.Count() * (double)Direction;
                X = uRadius * Math.Cos(Arc * (Percentage * (i + SD)));
                Y = uRadius * Math.Sin(Arc * (Percentage * (i + SD)));
                double Rotation;
                Items[Math.Abs(i)].x = (decimal)CenterPoint.X;
                Items[Math.Abs(i)].y = (decimal)CenterPoint.Y;
                Items[Math.Abs(i)].z = (decimal)CenterPoint.Z;
                int o90 = (Offset90) ? 90 : 0;
                if (Orientation == 0)
                {
                    Items[Math.Abs(i)].y = (decimal)(CenterPoint.Y + Y);
                    Items[Math.Abs(i)].x = (decimal)(CenterPoint.X + X);
                    Rotation = -1 * Math.Atan2((double)Items[Math.Abs(i)].y - CenterPoint.Y, (double)Items[Math.Abs(i)].x - CenterPoint.X) * (180 / Math.PI);
                    if (Rotate) Items[Math.Abs(i)].Rotation = (decimal)Rotation - o90;
                    if (Spiral && VertSpiral)
                    {
                        Items[Math.Abs(i)].z = (Decimal)CenterPoint.Z + ((decimal)Math.Abs(i) * (decimal)zStep);
                    }
                }
                else
                {
                    Items[Math.Abs(i)].z = (decimal)(CenterPoint.Z + Y);
                    if (Facing == 0)
                    {
                        Items[Math.Abs(i)].x = (decimal)(CenterPoint.X + X);
                        Rotation = Math.Atan2((double)Items[Math.Abs(i)].z - CenterPoint.Z, (double)Items[Math.Abs(i)].x - CenterPoint.X) * (180 / Math.PI);
                    }
                    else
                    {
                        Items[Math.Abs(i)].y = (decimal)(CenterPoint.Y + X);
                        Rotation = Math.Atan2((double)Items[Math.Abs(i)].z - CenterPoint.Z, (double)Items[Math.Abs(i)].y - CenterPoint.Y) * (180 / Math.PI);
                    }
                    if (TopPoint)
                    {
                        if (Rotate) Items[Math.Abs(i)].Pitch = (decimal)Rotation * -1 - o90;
                    }
                    else
                    {
                        if (Rotate) Items[Math.Abs(i)].Roll = (decimal)Rotation - o90;
                    }
                }
            }
            return Items;
        }
        internal static HouseItem[] Tile(
            HouseItem[] Items,
            Vector3D CenterPoint
            , decimal xSpacing
            , decimal ySpacing
            , decimal zSpacing
            , int xItems
            , int yItems
            , int zItems
            , decimal Scaling
            , bool IgnoreScaling = true
            , bool ZeroRotation = true
            )
        {
            int ItemsCount = Items.Count();
            int CurrentItem = 0;
            for (int z = 0; z < zItems; z++)
            {
                for (int y = 0; y < yItems; y++)
                {
                    for (int x = 0; x < xItems; x++)
                    {
                        if (CurrentItem >= ItemsCount) break;
                        decimal NewX = (decimal)CenterPoint.X - (decimal)x * xSpacing;
                        decimal NewY = (decimal)CenterPoint.Y - (decimal)y * ySpacing;
                        decimal NewZ = (decimal)CenterPoint.Z + (decimal)z * zSpacing;
                        Items[CurrentItem].x = NewX;
                        Items[CurrentItem].y = NewY;
                        Items[CurrentItem].z = NewZ;
                        if (!IgnoreScaling) Items[CurrentItem].Scale = Scaling;
                        if (ZeroRotation) Items[CurrentItem].Rotation = 0;
                        CurrentItem++;
                    }
                }
            }
            return Items;
        }
        internal static HouseItem[] RotateGroup(HouseItem[] Items, double RotationDegree, RotateAxis axis)
        {
            decimal minx, miny, minz
                , maxx, maxy, maxz
                , medx, medy, medz;
            minx = Items[0].x;
            maxx = minx;
            medx = minx;
            miny = Items[0].y;
            maxy = miny;
            medy = miny;
            minz = Items[0].z;
            maxz = minz;
            medz = minz;
            foreach (HouseItem item in Items)
            {
                if (item.x < minx) minx = item.x;
                if (item.x > maxx) maxx = item.x;
                if (item.y < miny) miny = item.y;
                if (item.y > maxy) maxy = item.y;
                if (item.z < minz) minz = item.z;
                if (item.z > maxz) maxz = item.z;
            }
            medx = minx + ((maxx - minx) / 2);
            medy = miny + ((maxy - miny) / 2);
            medz = minz + ((maxz - minz) / 2);
            int ItemCtr = Items.Length;
            for (int curritem = 0; curritem < ItemCtr; curritem++)
            {
                double opposite = 0, adjacent = 0;
                double itemdegree = 0, itemradius = 0;
                double radRotation = RotationDegree / 180 * Math.PI;
                switch (axis)
                {
                    case RotateAxis.x:
                        adjacent = (double)(Items[curritem].y - medy);
                        opposite = (double)(Items[curritem].z - medz);
                        if (adjacent == 0 && opposite > 0)
                        {
                            itemdegree = 0;
                        }
                        else if (adjacent == 0)
                        {
                            itemdegree = Math.PI;
                        }
                        else
                        {
                            itemdegree = Math.Atan2(opposite, adjacent);// * 180.0 / Math.PI;
                        }
                        itemradius = Math.Sqrt(Math.Pow(adjacent, 2.0) + Math.Pow(opposite, 2.0));
                        Items[curritem].y = (decimal)((double)medy + itemradius * Math.Cos(itemdegree + radRotation));
                        Items[curritem].z = (decimal)((double)medz + itemradius * Math.Sin(itemdegree + radRotation));
                        Items[curritem].Pitch += (decimal)RotationDegree;
                        break;
                    case RotateAxis.y:
                        adjacent = (double)(Items[curritem].x - medx);
                        opposite = (double)(Items[curritem].z - medz);
                        if (adjacent == 0 && opposite > 0)
                        {
                            itemdegree = 0;
                        }
                        else if (adjacent == 0)
                        {
                            itemdegree = Math.PI;
                        }
                        else
                        {
                            itemdegree = Math.Atan2(opposite, adjacent);// * 180.0 / Math.PI;
                        }
                        itemradius = Math.Sqrt(Math.Pow(adjacent, 2.0) + Math.Pow(opposite, 2.0));
                        Items[curritem].x = (decimal)((double)medx + itemradius * Math.Cos(itemdegree + radRotation));
                        Items[curritem].z = (decimal)((double)medz + itemradius * Math.Sin(itemdegree + radRotation));
                        Items[curritem].Roll += (decimal)RotationDegree;
                        break;
                    case RotateAxis.z:
                        adjacent = (double)(Items[curritem].x - medx);
                        opposite = (double)(Items[curritem].y - medy);
                        if (adjacent == 0 && opposite > 0)
                        {
                            itemdegree = 0;
                        }
                        else if (adjacent == 0)
                        {
                            itemdegree = Math.PI;
                        }
                        else
                        {
                            itemdegree = Math.Atan2(opposite, adjacent);// * 180.0 / Math.PI;
                        }
                        itemradius = Math.Sqrt(Math.Pow(adjacent, 2.0) + Math.Pow(opposite, 2.0));
                        Items[curritem].x = (decimal)((double)medx + itemradius * Math.Cos(itemdegree + radRotation));
                        Items[curritem].y = (decimal)((double)medy + itemradius * Math.Sin(itemdegree + radRotation));
                        Items[curritem].Rotation -= (decimal)RotationDegree;
                        break;
                }
            }
            return Items;
        }
    }
}

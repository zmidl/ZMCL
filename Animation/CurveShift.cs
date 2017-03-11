using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows;

namespace ZMCL.Animation
{
   public class CurveShift
   {
      private Storyboard StoryBoardObject;
      public Action ActionCompleted;

      public int PathWidth { get; set; }
      public Color PathColor { get; set; }

      public CurveShift(int pathWidth,Color pathColor)
      {
         this.PathWidth = pathWidth;
         this.PathColor = pathColor;
         this.StoryBoardObject = new Storyboard();
         this.StoryBoardObject.Completed += StoryBoardObject_Completed;
      }

      private void StoryBoardObject_Completed(object sender, EventArgs e)
      {
         ActionCompleted();
      }
      public void MovingAnimationByPath(UIElement target, Window scope, Path path, double timeSpan)
      {
         TranslateTransform translate = new TranslateTransform();
         target.RenderTransform = translate;

         NameScope.SetNameScope(scope, new NameScope());

         scope.RegisterName("translate", translate);

         DoubleAnimationUsingPath animationX = new DoubleAnimationUsingPath();
         animationX.PathGeometry = path.Data.GetFlattenedPathGeometry();
         animationX.Source = PathAnimationSource.X;
         animationX.Duration = new Duration(TimeSpan.FromSeconds(timeSpan));

         //animationX.AccelerationRatio = 10;
         DoubleAnimationUsingPath animationY = new DoubleAnimationUsingPath();
         animationY.PathGeometry = path.Data.GetFlattenedPathGeometry();
         animationY.Source = PathAnimationSource.Y;
         animationY.Duration = new Duration(TimeSpan.FromSeconds(timeSpan));
         //animationY.AccelerationRatio = 10;

         //story.AutoReverse = true;
         this.StoryBoardObject.RepeatBehavior = RepeatBehavior.Forever;
         this.StoryBoardObject.Children.Add(animationX);
         this.StoryBoardObject.Children.Add(animationY);
         Storyboard.SetTargetName(animationX, "translate");
         Storyboard.SetTargetName(animationY, "translate");
         Storyboard.SetTargetProperty(animationX, new PropertyPath(TranslateTransform.XProperty));
         Storyboard.SetTargetProperty(animationY, new PropertyPath(TranslateTransform.YProperty));
         //this.StoryBoardObject.Duration = new Duration(TimeSpan.FromSeconds(timeSpan));
         this.StoryBoardObject.Begin(scope);
      }

      public Path GetPath(List<Point> pointCollection)
      {
         Path path = new Path();

         PathGeometry pathGeometry = new PathGeometry();

         PathFigure pathFigure = new PathFigure();

         pathFigure.StartPoint = pointCollection[0];

         PathSegmentCollection segmentCollection = new PathSegmentCollection();

         for (int a = 0; a < pointCollection.Count; a++)
         {
            if (a > 0)
            {
               segmentCollection.Add(new LineSegment()
               {
                  Point = pointCollection[a]
               });
            }
         }

         pathFigure.Segments = segmentCollection;

         pathGeometry.Figures = new PathFigureCollection() { pathFigure };

         path.Data = pathGeometry;

         //Color c = SystemColors.ScrollBarBrushKey;
         path.Stroke = new SolidColorBrush(this.PathColor);

         path.StrokeThickness = this.PathWidth;

         return path;
      }
   }
}

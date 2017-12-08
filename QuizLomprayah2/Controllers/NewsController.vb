Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports QuizLomprayah2

Namespace Controllers
    Public Class NewsController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: News
        Function Index() As ActionResult
            Dim news = db.News.Include(Function(n) n.EmployeeInformation)
            Return View(news.ToList())
        End Function

        ' GET: News/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim news As News = db.News.Find(id)
            If IsNothing(news) Then
                Return HttpNotFound()
            End If
            Return View(news)
        End Function

        ' GET: News/Create
        Function Create() As ActionResult
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID")
            Return View()
        End Function

        ' POST: News/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="news_id,news_title,news_full_content,emp_id,date_news_published")> ByVal news As News) As ActionResult
            If ModelState.IsValid Then
                db.News.Add(news)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", news.emp_id)
            Return View(news)
        End Function

        ' GET: News/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim news As News = db.News.Find(id)
            If IsNothing(news) Then
                Return HttpNotFound()
            End If
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", news.emp_id)
            Return View(news)
        End Function

        ' POST: News/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="news_id,news_title,news_full_content,emp_id,date_news_published")> ByVal news As News) As ActionResult
            If ModelState.IsValid Then
                db.Entry(news).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", news.emp_id)
            Return View(news)
        End Function

        ' GET: News/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim news As News = db.News.Find(id)
            If IsNothing(news) Then
                Return HttpNotFound()
            End If
            Return View(news)
        End Function

        ' POST: News/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim news As News = db.News.Find(id)
            db.News.Remove(news)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

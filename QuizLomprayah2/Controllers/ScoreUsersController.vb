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
    Public Class ScoreUsersController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: ScoreUsers
        Function Index() As ActionResult
            Dim scoreUser = db.ScoreUser.Include(Function(s) s.book).Include(Function(s) s.EmployeeInformation)
            Return View(scoreUser.ToList())
        End Function

        ' GET: ScoreUsers/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim scoreUser As ScoreUser = db.ScoreUser.Find(id)
            If IsNothing(scoreUser) Then
                Return HttpNotFound()
            End If
            Return View(scoreUser)
        End Function

        ' GET: ScoreUsers/Create
        Function Create() As ActionResult
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code")
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID")
            Return View()
        End Function

        ' POST: ScoreUsers/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="score_id,emp_id,book_ID,Score,Status,Round,Scor_Date_Exam")> ByVal scoreUser As ScoreUser) As ActionResult
            If ModelState.IsValid Then
                db.ScoreUser.Add(scoreUser)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", scoreUser.book_ID)
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", scoreUser.emp_id)
            Return View(scoreUser)
        End Function

        ' GET: ScoreUsers/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim scoreUser As ScoreUser = db.ScoreUser.Find(id)
            If IsNothing(scoreUser) Then
                Return HttpNotFound()
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", scoreUser.book_ID)
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", scoreUser.emp_id)
            Return View(scoreUser)
        End Function

        ' POST: ScoreUsers/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="score_id,emp_id,book_ID,Score,Status,Round,Scor_Date_Exam")> ByVal scoreUser As ScoreUser) As ActionResult
            If ModelState.IsValid Then
                db.Entry(scoreUser).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", scoreUser.book_ID)
            ViewBag.emp_id = New SelectList(db.EmployeeInformation, "emp_id", "employee_ID", scoreUser.emp_id)
            Return View(scoreUser)
        End Function

        ' GET: ScoreUsers/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim scoreUser As ScoreUser = db.ScoreUser.Find(id)
            If IsNothing(scoreUser) Then
                Return HttpNotFound()
            End If
            Return View(scoreUser)
        End Function

        ' POST: ScoreUsers/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim scoreUser As ScoreUser = db.ScoreUser.Find(id)
            db.ScoreUser.Remove(scoreUser)
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

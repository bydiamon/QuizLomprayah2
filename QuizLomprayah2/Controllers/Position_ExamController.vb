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
    Public Class Position_ExamController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: Position_Exam
        Function Index() As ActionResult
            Dim position_Exam = db.Position_Exam.Include(Function(p) p.book)
            Return View(position_Exam.ToList())
        End Function

        ' GET: Position_Exam/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim position_Exam As Position_Exam = db.Position_Exam.Find(id)
            If IsNothing(position_Exam) Then
                Return HttpNotFound()
            End If
            Return View(position_Exam)
        End Function

        ' GET: Position_Exam/Create
        Function Create() As ActionResult
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code")
            Return View()
        End Function

        ' POST: Position_Exam/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="exam_id,Position_exam1,book_ID")> ByVal position_Exam As Position_Exam) As ActionResult
            If ModelState.IsValid Then
                db.Position_Exam.Add(position_Exam)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", position_Exam.book_ID)
            Return View(position_Exam)
        End Function

        ' GET: Position_Exam/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim position_Exam As Position_Exam = db.Position_Exam.Find(id)
            If IsNothing(position_Exam) Then
                Return HttpNotFound()
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", position_Exam.book_ID)
            Return View(position_Exam)
        End Function

        ' POST: Position_Exam/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="exam_id,Position_exam1,book_ID")> ByVal position_Exam As Position_Exam) As ActionResult
            If ModelState.IsValid Then
                db.Entry(position_Exam).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", position_Exam.book_ID)
            Return View(position_Exam)
        End Function

        ' GET: Position_Exam/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim position_Exam As Position_Exam = db.Position_Exam.Find(id)
            If IsNothing(position_Exam) Then
                Return HttpNotFound()
            End If
            Return View(position_Exam)
        End Function

        ' POST: Position_Exam/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim position_Exam As Position_Exam = db.Position_Exam.Find(id)
            db.Position_Exam.Remove(position_Exam)
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

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
    Public Class TrueFalsesController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: TrueFalses
        Function Index() As ActionResult
            Dim trueFalse = db.TrueFalse.Include(Function(t) t.book)
            Return View(trueFalse.ToList())
        End Function

        ' GET: TrueFalses/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trueFalse As TrueFalse = db.TrueFalse.Find(id)
            If IsNothing(trueFalse) Then
                Return HttpNotFound()
            End If
            Return View(trueFalse)
        End Function

        ' GET: TrueFalses/Create
        Function Create() As ActionResult
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code")
            Return View()
        End Function

        ' POST: TrueFalses/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="TrueFalse_id,book_ID,TrueFalse_Question,TrueFalse_Choice1,TrueFalse_Choice,TrueFalse_Answer,TrueFalse_ExamDate")> ByVal trueFalse As TrueFalse) As ActionResult
            If ModelState.IsValid Then
                db.TrueFalse.Add(trueFalse)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", trueFalse.book_ID)
            Return View(trueFalse)
        End Function

        ' GET: TrueFalses/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trueFalse As TrueFalse = db.TrueFalse.Find(id)
            If IsNothing(trueFalse) Then
                Return HttpNotFound()
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", trueFalse.book_ID)
            Return View(trueFalse)
        End Function

        ' POST: TrueFalses/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="TrueFalse_id,book_ID,TrueFalse_Question,TrueFalse_Choice1,TrueFalse_Choice,TrueFalse_Answer,TrueFalse_ExamDate")> ByVal trueFalse As TrueFalse) As ActionResult
            If ModelState.IsValid Then
                db.Entry(trueFalse).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", trueFalse.book_ID)
            Return View(trueFalse)
        End Function

        ' GET: TrueFalses/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim trueFalse As TrueFalse = db.TrueFalse.Find(id)
            If IsNothing(trueFalse) Then
                Return HttpNotFound()
            End If
            Return View(trueFalse)
        End Function

        ' POST: TrueFalses/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim trueFalse As TrueFalse = db.TrueFalse.Find(id)
            db.TrueFalse.Remove(trueFalse)
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

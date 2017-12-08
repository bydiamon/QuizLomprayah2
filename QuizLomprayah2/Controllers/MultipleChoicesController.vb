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
    Public Class MultipleChoicesController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: MultipleChoices
        Function Index() As ActionResult
            Dim multipleChoices = db.MultipleChoices.Include(Function(m) m.book)
            Return View(multipleChoices.ToList())
        End Function

        ' GET: MultipleChoices/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim multipleChoices As MultipleChoices = db.MultipleChoices.Find(id)
            If IsNothing(multipleChoices) Then
                Return HttpNotFound()
            End If
            Return View(multipleChoices)
        End Function

        ' GET: MultipleChoices/Create
        Function Create() As ActionResult
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code")
            Return View()
        End Function

        ' POST: MultipleChoices/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="MultipleChoices_id,book_ID,MultipleChoices_Question,Multiple_Choice1,Multiple_Choice2,Multiple_Choice3,Multiple_Choice4,Multiple_Answer,Multiple_ExamDate")> ByVal multipleChoices As MultipleChoices) As ActionResult
            If ModelState.IsValid Then
                db.MultipleChoices.Add(multipleChoices)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", multipleChoices.book_ID)
            Return View(multipleChoices)
        End Function

        ' GET: MultipleChoices/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim multipleChoices As MultipleChoices = db.MultipleChoices.Find(id)
            If IsNothing(multipleChoices) Then
                Return HttpNotFound()
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", multipleChoices.book_ID)
            Return View(multipleChoices)
        End Function

        ' POST: MultipleChoices/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="MultipleChoices_id,book_ID,MultipleChoices_Question,Multiple_Choice1,Multiple_Choice2,Multiple_Choice3,Multiple_Choice4,Multiple_Answer,Multiple_ExamDate")> ByVal multipleChoices As MultipleChoices) As ActionResult
            If ModelState.IsValid Then
                db.Entry(multipleChoices).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", multipleChoices.book_ID)
            Return View(multipleChoices)
        End Function

        ' GET: MultipleChoices/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim multipleChoices As MultipleChoices = db.MultipleChoices.Find(id)
            If IsNothing(multipleChoices) Then
                Return HttpNotFound()
            End If
            Return View(multipleChoices)
        End Function

        ' POST: MultipleChoices/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim multipleChoices As MultipleChoices = db.MultipleChoices.Find(id)
            db.MultipleChoices.Remove(multipleChoices)
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

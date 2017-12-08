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
    Public Class EssayTestsController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: EssayTests
        Function Index() As ActionResult
            Dim essayTest = db.EssayTest.Include(Function(e) e.book)
            Return View(essayTest.ToList())
        End Function

        ' GET: EssayTests/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim essayTest As EssayTest = db.EssayTest.Find(id)
            If IsNothing(essayTest) Then
                Return HttpNotFound()
            End If
            Return View(essayTest)
        End Function

        ' GET: EssayTests/Create
        Function Create() As ActionResult
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code")
            Return View()
        End Function

        ' POST: EssayTests/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="EssayTest_id,book_ID,EssayTest_Question,EssayTest_Answer_User,EssayTest_Answer,EssayTest_ExamDate")> ByVal essayTest As EssayTest) As ActionResult
            If ModelState.IsValid Then
                db.EssayTest.Add(essayTest)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", essayTest.book_ID)
            Return View(essayTest)
        End Function

        ' GET: EssayTests/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim essayTest As EssayTest = db.EssayTest.Find(id)
            If IsNothing(essayTest) Then
                Return HttpNotFound()
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", essayTest.book_ID)
            Return View(essayTest)
        End Function

        ' POST: EssayTests/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="EssayTest_id,book_ID,EssayTest_Question,EssayTest_Answer_User,EssayTest_Answer,EssayTest_ExamDate")> ByVal essayTest As EssayTest) As ActionResult
            If ModelState.IsValid Then
                db.Entry(essayTest).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.book_ID = New SelectList(db.book, "book_ID", "subject_code", essayTest.book_ID)
            Return View(essayTest)
        End Function

        ' GET: EssayTests/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim essayTest As EssayTest = db.EssayTest.Find(id)
            If IsNothing(essayTest) Then
                Return HttpNotFound()
            End If
            Return View(essayTest)
        End Function

        ' POST: EssayTests/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim essayTest As EssayTest = db.EssayTest.Find(id)
            db.EssayTest.Remove(essayTest)
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

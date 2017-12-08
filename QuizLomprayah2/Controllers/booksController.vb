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
    Public Class booksController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: books
        Function Index() As ActionResult
            Return View(db.book.ToList())
        End Function

        ' GET: books/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.book.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' GET: books/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: books/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="book_ID,subject_code,Name_book,type_book,Date_Start_Book,Creator,FilePath")> ByVal book As book) As ActionResult
            If ModelState.IsValid Then
                db.book.Add(book)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(book)
        End Function

        ' GET: books/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.book.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: books/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="book_ID,subject_code,Name_book,type_book,Date_Start_Book,Creator,FilePath")> ByVal book As book) As ActionResult
            If ModelState.IsValid Then
                db.Entry(book).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(book)
        End Function

        ' GET: books/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As book = db.book.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: books/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim book As book = db.book.Find(id)
            db.book.Remove(book)
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

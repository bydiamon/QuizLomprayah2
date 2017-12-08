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
    Public Class PositionTablesController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: PositionTables
        Function Index() As ActionResult
            Return View(db.PositionTable.ToList())
        End Function

        ' GET: PositionTables/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim positionTable As PositionTable = db.PositionTable.Find(id)
            If IsNothing(positionTable) Then
                Return HttpNotFound()
            End If
            Return View(positionTable)
        End Function

        ' GET: PositionTables/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: PositionTables/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Position_id,Position_Title")> ByVal positionTable As PositionTable) As ActionResult
            If ModelState.IsValid Then
                db.PositionTable.Add(positionTable)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(positionTable)
        End Function

        ' GET: PositionTables/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim positionTable As PositionTable = db.PositionTable.Find(id)
            If IsNothing(positionTable) Then
                Return HttpNotFound()
            End If
            Return View(positionTable)
        End Function

        ' POST: PositionTables/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Position_id,Position_Title")> ByVal positionTable As PositionTable) As ActionResult
            If ModelState.IsValid Then
                db.Entry(positionTable).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(positionTable)
        End Function

        ' GET: PositionTables/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim positionTable As PositionTable = db.PositionTable.Find(id)
            If IsNothing(positionTable) Then
                Return HttpNotFound()
            End If
            Return View(positionTable)
        End Function

        ' POST: PositionTables/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim positionTable As PositionTable = db.PositionTable.Find(id)
            db.PositionTable.Remove(positionTable)
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

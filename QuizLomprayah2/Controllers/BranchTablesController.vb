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
    Public Class BranchTablesController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: BranchTables
        Function Index() As ActionResult
            Dim branchTable = db.BranchTable.Include(Function(b) b.PositionTable)
            Return View(branchTable.ToList())
        End Function

        ' GET: BranchTables/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim branchTable As BranchTable = db.BranchTable.Find(id)
            If IsNothing(branchTable) Then
                Return HttpNotFound()
            End If
            Return View(branchTable)
        End Function

        ' GET: BranchTables/Create
        Function Create() As ActionResult
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title")
            Return View()
        End Function

        ' POST: BranchTables/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Branch_id,Branch_Title,Position_id")> ByVal branchTable As BranchTable) As ActionResult
            If ModelState.IsValid Then
                db.BranchTable.Add(branchTable)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", branchTable.Position_id)
            Return View(branchTable)
        End Function

        ' GET: BranchTables/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim branchTable As BranchTable = db.BranchTable.Find(id)
            If IsNothing(branchTable) Then
                Return HttpNotFound()
            End If
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", branchTable.Position_id)
            Return View(branchTable)
        End Function

        ' POST: BranchTables/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Branch_id,Branch_Title,Position_id")> ByVal branchTable As BranchTable) As ActionResult
            If ModelState.IsValid Then
                db.Entry(branchTable).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", branchTable.Position_id)
            Return View(branchTable)
        End Function

        ' GET: BranchTables/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim branchTable As BranchTable = db.BranchTable.Find(id)
            If IsNothing(branchTable) Then
                Return HttpNotFound()
            End If
            Return View(branchTable)
        End Function

        ' POST: BranchTables/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim branchTable As BranchTable = db.BranchTable.Find(id)
            db.BranchTable.Remove(branchTable)
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

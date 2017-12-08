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
    Public Class EmployeeInformationsController
        Inherits System.Web.Mvc.Controller

        Private db As New QuizLomprayahEntities

        ' GET: EmployeeInformations
        Function Index() As ActionResult
            Dim employeeInformation = db.EmployeeInformation.Include(Function(e) e.BranchTable).Include(Function(e) e.PositionTable)
            Return View(employeeInformation.ToList())
        End Function

        ' GET: EmployeeInformations/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeInformation As EmployeeInformation = db.EmployeeInformation.Find(id)
            If IsNothing(employeeInformation) Then
                Return HttpNotFound()
            End If
            Return View(employeeInformation)
        End Function

        ' GET: EmployeeInformations/Create
        Function Create() As ActionResult
            ViewBag.Branch_id = New SelectList(db.BranchTable, "Branch_id", "Branch_Title")
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title")
            Return View()
        End Function

        ' POST: EmployeeInformations/Create
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="emp_id,employee_ID,Name,LastName,Position_id,Department,Branch_id,StartDate")> ByVal employeeInformation As EmployeeInformation) As ActionResult
            If ModelState.IsValid Then
                db.EmployeeInformation.Add(employeeInformation)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Branch_id = New SelectList(db.BranchTable, "Branch_id", "Branch_Title", employeeInformation.Branch_id)
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", employeeInformation.Position_id)
            Return View(employeeInformation)
        End Function

        ' GET: EmployeeInformations/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeInformation As EmployeeInformation = db.EmployeeInformation.Find(id)
            If IsNothing(employeeInformation) Then
                Return HttpNotFound()
            End If
            ViewBag.Branch_id = New SelectList(db.BranchTable, "Branch_id", "Branch_Title", employeeInformation.Branch_id)
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", employeeInformation.Position_id)
            Return View(employeeInformation)
        End Function

        ' POST: EmployeeInformations/Edit/5
        'To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="emp_id,employee_ID,Name,LastName,Position_id,Department,Branch_id,StartDate")> ByVal employeeInformation As EmployeeInformation) As ActionResult
            If ModelState.IsValid Then
                db.Entry(employeeInformation).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.Branch_id = New SelectList(db.BranchTable, "Branch_id", "Branch_Title", employeeInformation.Branch_id)
            ViewBag.Position_id = New SelectList(db.PositionTable, "Position_id", "Position_Title", employeeInformation.Position_id)
            Return View(employeeInformation)
        End Function

        ' GET: EmployeeInformations/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim employeeInformation As EmployeeInformation = db.EmployeeInformation.Find(id)
            If IsNothing(employeeInformation) Then
                Return HttpNotFound()
            End If
            Return View(employeeInformation)
        End Function

        ' POST: EmployeeInformations/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim employeeInformation As EmployeeInformation = db.EmployeeInformation.Find(id)
            db.EmployeeInformation.Remove(employeeInformation)
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

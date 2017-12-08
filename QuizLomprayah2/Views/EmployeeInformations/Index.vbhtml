@ModelType IEnumerable(Of QuizLomprayah2.EmployeeInformation)
@Code
ViewData("Title") = "Index"
End Code
    <h2>Index</h2>

    <p>
        @Html.ActionLink("Create New", "Create")
    </p>
    <table class="table">
        <tr>
            <th>
                @Html.DisplayNameFor(Function(model) model.employee_ID)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Name)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.LastName)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.Department)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.StartDate)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.BranchTable.Branch_Title)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.PositionTable.Position_Title)
            </th>
            <th></th>
        </tr>

        @For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.employee_ID)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LastName)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Department)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.StartDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.BranchTable.Branch_Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PositionTable.Position_Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.emp_id}) |
            @Html.ActionLink("Details", "Details", New With {.id = item.emp_id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.emp_id})
        </td>
    </tr>
        Next

    </table>
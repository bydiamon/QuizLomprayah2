@ModelType IEnumerable(Of QuizLomprayah2.ScoreUser)
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
            @Html.DisplayNameFor(Function(model) model.Score)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Status)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Round)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Scor_Date_Exam)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployeeInformation.employee_ID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Score)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Status)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Round)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Scor_Date_Exam)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book.subject_code)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployeeInformation.employee_ID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.score_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.score_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.score_id })
        </td>
    </tr>
Next

</table>

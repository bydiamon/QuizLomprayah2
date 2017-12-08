@ModelType IEnumerable(Of QuizLomprayah2.TrueFalse)
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
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Question)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Choice1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Choice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Answer)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_ExamDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TrueFalse_Question)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TrueFalse_Choice1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TrueFalse_Choice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TrueFalse_Answer)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TrueFalse_ExamDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book.subject_code)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.TrueFalse_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.TrueFalse_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.TrueFalse_id })
        </td>
    </tr>
Next

</table>

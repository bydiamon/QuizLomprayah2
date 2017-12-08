@ModelType IEnumerable(Of QuizLomprayah2.Position_Exam)
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
            @Html.DisplayNameFor(Function(model) model.Position_exam1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Position_exam1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book.subject_code)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.exam_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.exam_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.exam_id })
        </td>
    </tr>
Next

</table>

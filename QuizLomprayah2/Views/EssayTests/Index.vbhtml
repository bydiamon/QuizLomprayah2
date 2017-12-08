@ModelType IEnumerable(Of QuizLomprayah2.EssayTest)
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
            @Html.DisplayNameFor(Function(model) model.EssayTest_Question)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer_User)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EssayTest_Answer)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EssayTest_ExamDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EssayTest_Question)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EssayTest_Answer_User)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EssayTest_Answer)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EssayTest_ExamDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book.subject_code)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.EssayTest_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.EssayTest_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.EssayTest_id })
        </td>
    </tr>
Next

</table>

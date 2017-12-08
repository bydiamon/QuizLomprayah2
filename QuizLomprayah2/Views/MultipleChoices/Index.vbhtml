@ModelType IEnumerable(Of QuizLomprayah2.MultipleChoices)
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
            @Html.DisplayNameFor(Function(model) model.MultipleChoices_Question)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice3)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice4)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_Answer)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Multiple_ExamDate)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.MultipleChoices_Question)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_Choice1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_Choice2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_Choice3)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_Choice4)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_Answer)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Multiple_ExamDate)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.book.subject_code)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.MultipleChoices_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.MultipleChoices_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.MultipleChoices_id })
        </td>
    </tr>
Next

</table>

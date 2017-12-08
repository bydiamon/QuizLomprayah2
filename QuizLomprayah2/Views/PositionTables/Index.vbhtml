@ModelType IEnumerable(Of QuizLomprayah2.PositionTable)
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
            @Html.DisplayNameFor(Function(model) model.Position_Title)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Position_Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Position_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Position_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Position_id })
        </td>
    </tr>
Next

</table>

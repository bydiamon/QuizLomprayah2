@ModelType IEnumerable(Of QuizLomprayah2.BranchTable)
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
            @Html.DisplayNameFor(Function(model) model.Branch_Title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.PositionTable.Position_Title)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Branch_Title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.PositionTable.Position_Title)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.Branch_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.Branch_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.Branch_id })
        </td>
    </tr>
Next

</table>

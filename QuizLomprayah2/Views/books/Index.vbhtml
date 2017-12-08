@ModelType IEnumerable(Of QuizLomprayah2.book)
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
            @Html.DisplayNameFor(Function(model) model.subject_code)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Name_book)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.type_book)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Date_Start_Book)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Creator)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FilePath)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.subject_code)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Name_book)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.type_book)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Date_Start_Book)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Creator)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FilePath)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.book_ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.book_ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.book_ID })
        </td>
    </tr>
Next

</table>

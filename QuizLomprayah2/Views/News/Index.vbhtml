@ModelType IEnumerable(Of QuizLomprayah2.News)
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
            @Html.DisplayNameFor(Function(model) model.news_title)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.news_full_content)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.date_news_published)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.EmployeeInformation.employee_ID)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.news_title)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.news_full_content)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.date_news_published)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.EmployeeInformation.employee_ID)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.news_id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.news_id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.news_id })
        </td>
    </tr>
Next

</table>

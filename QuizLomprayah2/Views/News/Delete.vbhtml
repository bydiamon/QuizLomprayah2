@ModelType QuizLomprayah2.News
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>News</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.news_title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.news_title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.news_full_content)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.news_full_content)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.date_news_published)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.date_news_published)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EmployeeInformation.employee_ID)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EmployeeInformation.employee_ID)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>

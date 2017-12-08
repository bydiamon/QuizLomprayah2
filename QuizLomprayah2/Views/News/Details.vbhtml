@ModelType QuizLomprayah2.News
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.news_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
